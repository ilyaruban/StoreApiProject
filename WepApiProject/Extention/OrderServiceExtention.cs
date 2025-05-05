using WepApiProject.Service;

namespace WepApiProject.Extention
{
    public static class OrderServiceExtention
    {
        public static IServiceCollection AddOrderService(
            this IServiceCollection services)
        {
            services.AddScoped<OrdersService>();
            return services;
        }
    }
}
