using Microsoft.AspNetCore.Identity;
using System.Runtime.CompilerServices;
using WepApiProject.Common;

namespace WepApiProject.Extention
{
    public static class RoleInitilizerServiceExtension
    {
        public static async Task InitialiseRoleAsync(this IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();

            //менеджер ролей
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            foreach(var role in SharedData.Roles.AllRoles)
            {
                if(await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
    }
}
