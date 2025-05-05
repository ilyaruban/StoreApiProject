using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace WepApiProject.Extention
{
    public static class AuthenticationServiceExtension
    {
        //новый метод расширения для IServiceCollection
        public static IServiceCollection AddAuthenticationConfig(this IServiceCollection services,
            IConfiguration config)
        {
            //получаем секретный ключ, которым подписывали токены
            var authSettingsToken = config["AuthSettings:SecretKey"];

            services.AddAuthentication(p =>
            {
                //задаем схему аутентификации, которая будет использоваться по умолчанию
                p.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                p.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(p =>
            {
                //отключает требования https для метаданных токена
                p.RequireHttpsMetadata = false;
                //токен должен сохраняться в http контексте после успешной аутентификации
                p.SaveToken = true;
                //задаем параметры валидации токена
                p.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    //включаем проверку ключа
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(authSettingsToken)),
                    //отключаем проверку издателя токена
                    ValidateIssuer = false,
                    //отключаем проверку, для кого предназначем токен
                    ValidateAudience = false
                };
            });

            return services;
        }
    }
}
