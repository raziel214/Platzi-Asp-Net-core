using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Platzi_Asp_Net_core.Models;

namespace Platzi_Asp_Net_core.Controllers {
    public class EscuelaController : Controller {
        private EscuelaContext _context;
        
        public IActionResult Index () {
            ViewBag.CosaDinamica = "La Monja";
            var escuela = _context.Escuelas.FirstOrDefault ();
            return View (escuela);
        }

        public EscuelaController (EscuelaContext context) {
            _context = context;
        }
    }
}