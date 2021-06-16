using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pc04.Models;

namespace pc04.Controllers
{
    public class HomeController : Controller
    {
        private readonly PeruContext _context;

        public HomeController(PeruContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var memasos = _context.fails.Count();
            List<Fail> mostrar = new List<Fail>();
            if (memasos > 9)
            {
                var cont = memasos - 10 ;
                
                for (int i = cont; i <= memasos; i++)
                {
                var x = _context.fails.Find(i);
                mostrar.Add(x);
                
                }
            
            }else{
                
                for (int i = 1; i <= memasos; i++)
                {
                var x = _context.fails.Find(i);
                mostrar.Add(x);
               
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
