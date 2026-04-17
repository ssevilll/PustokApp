using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokAppMvc.Data;
using PustokAppMvc.Models;
using PustokAppMvc.ViewModel;

namespace PustokAppMvc.Controllers
{
    public class HomeController(AppDbContext dbContext) : Controller
    {
       

        public IActionResult Index()
        {
            HomeVm homeVm = new HomeVm
            {
                Sliders = dbContext.Sliders.ToList(),

                FeaturedBooks = dbContext.Books
                .Include(x => x.BookImages)
                .Include(x => x.Author)
                .Where(x => x.IsFeatured).ToList(),

                NewBooks = dbContext.Books
                .Include(x => x.BookImages)
                .Include(x => x.Author)
                .Where(x => x.IsNew).ToList(),

                DiscountedBooks = dbContext.Books
                .Include(x => x.BookImages)
                .Include(x => x.Author)
                .Where(x => x.DiscountPercent > 0).ToList()
            };

            return View(homeVm);
        }

       
    }
}
