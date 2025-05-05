using Microsoft.AspNetCore.Identity;

namespace WepApiProject.Extention
{
    public static class IdentityOptionsExtention
    {
        public static IServiceCollection AddConfigureIdentityOptions(
            this IServiceCollection services)
        {
            //конфигурирование сложности пароля
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 1;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            });

            return services;
        }
    }
}
