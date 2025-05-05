using Microsoft.EntityFrameworkCore;
using WepApiProject.DataContext;
using WepApiProject.Model;

namespace WepApiProject.Service
{
    public class ShoppingCartService
    {
        private readonly AppDbContext context;
        public ShoppingCartService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task CreateNewCartAsync(string userId, int productId, int quantity)
        {
            ShoppingCart newCart = new ShoppingCart
            {
                UserId = userId
            };

            await context.ShoppingCarts.AddAsync(newCart);
            await context.SaveChangesAsync();

            CartItem item = new CartItem
            {
                ProductId = productId,
                Quantity = quantity,
                ShoppingCardId = newCart.Id,
                Product = null
            };

            await context.CartItems.AddAsync(item);
            await context.SaveChangesAsync();
        }

        //метод обновления товаров в корзине
        public async Task UpdateExistingCartAsync(
            ShoppingCart shoppingCart, int productId, int newQuantity)
        {
            CartItem cartItemInCart = shoppingCart.CartItems.FirstOrDefault(p => p.ProductId == productId);

            if (cartItemInCart == null && newQuantity > 0)
            {
                CartItem cartItem = new CartItem
                {
                    ProductId = productId,
                    Quantity = newQuantity,
                    ShoppingCardId = shoppingCart.Id,
                    Product = null
                };

                await context.CartItems.AddAsync(cartItem);
            }
            else if (cartItemInCart != null)
            {
                int updateQuantity = cartItemInCart.Quantity + newQuantity;

                if (newQuantity == 0 || updateQuantity <= 0)
                {
                    context.CartItems.Remove(cartItemInCart);

                    if (shoppingCart.CartItems.Count == 1)
                    {
                        context.ShoppingCarts.Remove(shoppingCart);
                    }
                }
                else
                {
                    cartItemInCart.Quantity = newQuantity;
                }
            }

            await context.SaveChangesAsync();
        }

        //получение корзины
        public async Task<ShoppingCart> GetShoppingCartAsync(string userId)
        {
            //если новый пользователь
            if (string.IsNullOrEmpty(userId))
            {
                //возвращаем новую корзину
                return new ShoppingCart();
            }

            ShoppingCart shoppingCart = await context.ShoppingCarts.Include(p => p.CartItems)
                                                     .ThenInclude(p => p.Product).FirstOrDefaultAsync(p => p.UserId == userId);

            if (shoppingCart != null && shoppingCart.CartItems != null)
            {
                shoppingCart.TotalAmount = shoppingCart.CartItems.Sum(p => p.Quantity * p.Product.Price);
            }

            return shoppingCart;
        }
    }
}
