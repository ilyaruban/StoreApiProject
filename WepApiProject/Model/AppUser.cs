using Microsoft.AspNetCore.Identity;

namespace WepApiProject.Model
{
    public class AppUser: IdentityUser
    {
        public string FirstName {  get; set; }
    }
}
