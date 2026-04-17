using Microsoft.AspNetCore.Identity;

namespace PustokAppMvc.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
