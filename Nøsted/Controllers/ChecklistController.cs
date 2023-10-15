using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Dapper;

namespace Nøsted.Controllers
{
    public class ChecklistController : Controller
    {
        
        
        public IActionResult Lag()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Lag(Skjema skjema)
        {
            if (ModelState.IsValid)
            {
                
            }
            return View(skjema);
        }
        
        
    }
}
