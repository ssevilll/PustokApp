using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PustokAppMvc.Areas.Manage.ViewModels;
using PustokAppMvc.Models;
using System.Threading.Tasks;

namespace PustokAppMvc.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class AdminAccountController
        (
        UserManager<AppUser> userManager,
        RoleManager<IdentityRole> roleManager,
        SignInManager<AppUser> signInManager
        ) : Controller
    {
        public async Task<IActionResult> CreateAdmin()
        {
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }
            if (!await roleManager.RoleExistsAsync("Member"))
            {
                await roleManager.CreateAsync(new IdentityRole("Member"));
            }

            AppUser admin = new AppUser
            {
                UserName = "_admin",
                FullName = "Admin Adminov",
                Email = "admin@example.com"
            };
            IdentityResult result = await userManager.CreateAsync(admin, "_Admin123!");
            if (result.Succeeded) {
                await userManager.AddToRoleAsync(admin, "Admin");
                return Content("Admin account has been created successfully");
            }
            
            return Content($"Failed to create admin: {string.Join(", ", result.Errors.Select(e => e.Description))}");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AdminLoginVm loginvm)
        {
            if (!ModelState.IsValid)
                return View(loginvm);

            var admin= await userManager.FindByNameAsync(loginvm.Username);
            if (admin == null) {
                ModelState.AddModelError("", "Invalid username or password");
                return View(loginvm);
            }

            var result = await userManager.CheckPasswordAsync(admin, loginvm.Password);
            if (!result) {
                ModelState.AddModelError("", "Invalid username or password");
                return View(loginvm);
            }

            await signInManager.SignInAsync(admin, true);
            return RedirectToAction("index", "dashboard");
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("login");
        }
  
    }
}
