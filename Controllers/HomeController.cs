using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pc04.Models;

namespace pc04.Controllers
{
    public class HomeController : Controller
    {
        private readonly PeruContext _context;
        private readonly SignInManager<IdentityUser> _sim;
        private readonly UserManager<IdentityUser> _um;

        public HomeController(PeruContext context , SignInManager<IdentityUser>  sim , UserManager<IdentityUser>  um)
        {
            _context = context;
            _sim = sim;
            _um = um;
        }

        public IActionResult Index()
        {
            var memasos = _context.fails.Count();
            List<Fail> mostrar = new List<Fail>();
            int contar = 0;
            var orden = _context.fails.OrderByDescending(d => d.fecha).ToList();
            if (memasos <= 10)
            {
                mostrar = orden;
            }else
            {
               foreach (var item in orden)
               {
                   if (contar < 10)
                   {
                       mostrar.Add(item);
                       contar++;
                   }                  
               }
            }
            return View(mostrar);
            
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
