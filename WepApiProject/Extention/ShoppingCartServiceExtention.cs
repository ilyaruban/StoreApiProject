using WepApiProject.Service;

namespace WepApiProject.Extention
{
    public static class ShoppingCartServiceExtention
    {
        public static IServiceCollection AddShoppingCartService(this IServiceCollection services)
        {
            return services.AddScoped<ShoppingCartService>();
        }
    }
}
