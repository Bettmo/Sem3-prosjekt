using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Nøsted.Controllers
{
    public class ChecklistController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChecklistController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Lag()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Lag(Skjema skjema)
        {
            if (ModelState.IsValid)
            {
                _context.Skjema.Add(skjema);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(skjema);
        }
    }
}
