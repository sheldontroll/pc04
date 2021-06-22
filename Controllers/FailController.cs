using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using pc04.Models;

namespace pc04.Controllers
{
    public class FailController : Controller
    {
        private readonly PeruContext _context;
        private readonly SignInManager<IdentityUser> _sim;
        private readonly UserManager<IdentityUser> _um;

        public FailController(PeruContext context, SignInManager<IdentityUser>  sim , UserManager<IdentityUser>  um){
            _context = context;
            _um = um;
            _sim = sim;
        }
        public IActionResult Fail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Fail(Fail f)
        {
            if (ModelState.IsValid){
                f.usuario = _um.GetUserName(User);
                _context.fails.Add(f);
                _context.SaveChanges();
                return RedirectToAction("Index","Home");
            }else{
            return View();
            }
        }
    }
}