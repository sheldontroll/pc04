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
            var memasos = _context.fails.ToList();
            return View(memasos);
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
