using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokAppMvc.Data;
using PustokAppMvc.Models;

namespace PustokAppMvc.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class AuthorController(AppDbContext context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var authors = await context.Authors.ToListAsync();
            return View(authors);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var author = await context.Authors.FirstOrDefaultAsync(x => x.Id == id);
            if (author == null) return Json(new { success = false, message = "Author not found" });
            context.Authors.Remove(author);
            await context.SaveChangesAsync();
            return Json(new { success = true, message = "Author deleted successfully" });
        }

        public async Task<IActionResult> ModalDetails(Guid id)
        {
            var author = await context.Authors.FirstOrDefaultAsync(x => x.Id == id);
            if (author == null) return NotFound();
            return PartialView("_ModalDetailsPartial", author);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Author author)
        {
            if (!ModelState.IsValid)
            {
                return View(author);
            }

            if (context.Authors.Any(a => a.FullName.ToLower() == author.FullName.ToLower()))
            {
                ModelState.AddModelError("FulName", "Author with the same name already exist");
                return View(author);
            }
            
            await context.Authors.AddAsync(author);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(Guid id) 
        {
            var author=context.Authors.Find(id);
            if (author == null) return NotFound();
            return View(author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Author author)
        {
            if (!ModelState.IsValid) 
                return View(author);

            var existing=context.Authors.FirstOrDefault(a=>a.Id == author.Id);
            if (existing == null) return NotFound();
            if (context.Authors.Any(a => a.FullName.ToLower() == author.FullName.ToLower() && a.Id!=author.Id))
            {
                ModelState.AddModelError("FullName", "Author with the same name already exist");
                return View(author);
            }
            existing.FullName= author.FullName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

