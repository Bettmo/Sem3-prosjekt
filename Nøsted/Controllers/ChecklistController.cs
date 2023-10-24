using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Nøsted.Controllers
{
    pubic class ChecklistController : Controller
    {
        private readonly AppDbContext _context:

        public ChecklistController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Save(CheclistModel model)
        {
            ChecklistEntity newChecklist = new ChecklistEntity
            {
                SerieNR = model.SerieNR,
            };

            if ()

            if (ModelState.IsValid)
            {
               

            }
            return View("Index", model);
        }

    }
}