using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using pc04.Models;

namespace pc04.Controllers
{
    public class ComentarioController :Controller
    {
        private readonly PeruContext _context;

        public ComentarioController(PeruContext context){
            _context = context;
        }
        public IActionResult Comentario()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Comentario(int idfail)
        {
            var fai = _context.fails.Find(idfail);
            Fail m = new Fail();
            m = fai;
            List<Fail> fa = new List<Fail>();
            fa.Add(m);
            return View(fa);
        }

    }
}