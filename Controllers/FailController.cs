using Microsoft.AspNetCore.Mvc;
using pc04.Models;

namespace pc04.Controllers
{
    public class FailController : Controller
    {
        private readonly PeruContext _context;

        public FailController(PeruContext context){
            _context = context;
        }
        public IActionResult Fail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Fail(Fail f)
        {
            if (ModelState.IsValid){
                _context.fails.Add(f);
                _context.SaveChanges();
                return RedirectToAction("Index","Home");
            }else{
            return View();
            }
        }
    }
}