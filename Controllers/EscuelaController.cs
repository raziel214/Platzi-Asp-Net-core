using System;
using Microsoft.AspNetCore.Mvc;
using Platzi_Asp_Net_core.Models;

namespace Platzi_Asp_Net_core.Controllers {
    public class EscuelaController : Controller {

        public IActionResult Index () {
            var escuela = new Escuela ();
            escuela.AñoFundacion = 2001;
            escuela.EscuelaId = Guid.NewGuid ().ToString ();
            escuela.EscuelaNombre = "Platzi Schoool";
            ViewBag.CosaDinamica="Las Mejores pruebas";
            return View (escuela);
        }

    }
}