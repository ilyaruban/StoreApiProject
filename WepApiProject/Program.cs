using WepApiProject.Extention;

namespace WepApiProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddControllers();

            builder.Services.AddPostgreSqlServiceExtention(builder.Configuration);
            builder.Services.AddPostgreSqlIdentityContext();
            builder.Services.AddConfigureIdentityOptions();
            builder.Services.AddJwtTokenGenerator();
            builder.Services.AddAuthenticationConfig(builder.Configuration);
            builder.Services.AddCors();
            builder.Services.AddShoppingCartService();

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();
            app.MapControllers();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors(options=>options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().WithExposedHeaders("*"));
            app.UseAuthentication();

            RunMethod(app);

            app.UseAuthorization();

            app.MapGet("/hello", () => "hello api");

            app.MapControllers();            

            app.Run();
        }

        public async static Task RunMethod(WebApplication app)
        {
            await app.Services.InitialiseRoleAsync();
        }
    }
}
