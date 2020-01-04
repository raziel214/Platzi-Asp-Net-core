using System;
using Microsoft.AspNetCore.Mvc;
using Platzi_Asp_Net_core.Models;

namespace Platzi_Asp_Net_core.Controllers {
    public class EscuelaController : Controller {

        public IActionResult Index () {
            var escuela = new Escuela ();
            escuela.AñoDeCreación = 2001;
            escuela.UniqueId = Guid.NewGuid ().ToString ();
            escuela.Nombre = "Platzi Schoool";
            escuela.Dirección="calle 72L #28 D3 -11";
            escuela.Pais="Colombia";
            escuela.Ciudad="Cali";
            ViewBag.CosaDinamica="Las Mejores pruebas";
            return View (escuela);
        }

    }
}