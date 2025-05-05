using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WepApiProject.DataContext;
using WepApiProject.Model;
using WepApiProject.Service;

namespace WepApiProject.Controllers
{
    public class ShoppingCartController : StoreController
    {
        private readonly ShoppingCartService shoppingCartService;
        public ShoppingCartController(AppDbContext context, ShoppingCartService shoppingCartService) : base(context)
        {
            this.shoppingCartService = shoppingCartService;
        }

        [HttpGet]
        public async Task<ActionResult<ResponceServer>> AppendOrUpdateItemInCart(
            string userId, int productId, int updateQuantity)
        {
            Product product = await Context.Products.FirstOrDefaultAsync(p => p.Id == productId);

            if (product == null)
            {
                return BadRequest(new ResponceServer
                {
                    IsSuccess = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    ErrorMessages = { "Такой товар не найден" }
                });
            }

            ShoppingCart shoppingCart = await Context.ShoppingCarts.Include(p => p.CartItems).FirstOrDefaultAsync(p => p.UserId == userId);

            if (shoppingCart == null && updateQuantity > 0)
            {
                await shoppingCartService.CreateNewCartAsync(userId, productId, updateQuantity);
            }
            else if (shoppingCart != null)
            {
                await shoppingCartService.UpdateExistingCartAsync(shoppingCart, productId, updateQuantity);
            }

            return Ok(new ResponceServer
            {
                StatusCode = System.Net.HttpStatusCode.OK
            });
        }

        [HttpGet]

        public async Task<ActionResult<ResponceServer>> GetShoppingCart(string userId)
        {
            try
            {
                ShoppingCart shoppingCart = await shoppingCartService.GetShoppingCartAsync(userId);

                return Ok(new ResponceServer
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    Result = shoppingCart
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponceServer
                {
                    IsSuccess = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    ErrorMessages = { "Ошибка получения корзины", ex.Message }
                });
            }
        }
    }
}
