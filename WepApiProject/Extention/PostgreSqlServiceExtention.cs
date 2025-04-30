using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WepApiProject.DataContext;
using WepApiProject.Model;

namespace WepApiProject.Extention
{
    public static class PostgreSqlServiceExtention
    {
        public static void AddPostgreSqlServiceExtention(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("PostgreSQLConnection"));
            });
        }

        public static void AddPostgreSqlIdentityContext(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
        }
    }
}
