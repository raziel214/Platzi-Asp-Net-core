using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Platzi_Asp_Net_core.Models;

namespace Platzi_Asp_Net_core.Controllers {
    public class AlumnoController : Controller {
        private EscuelaContext _context;

        [Route("Alumno/Index")]
        [Route("Alumno/Index/{alumnoId}")]
        public IActionResult Index (string alumnoId) {
            if (!string.IsNullOrWhiteSpace(alumnoId))
            {

                var asignatura = from alumn in _context.Alumnos
                                 where alumn.Id == alumnoId
                                 select alumn;

                return View(asignatura.SingleOrDefault());
            }
            else
            {
                return View("MultiAlumno", _context.Alumnos);
            }
        }



        public IActionResult MultiAalumno () {
         

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            //return View ("MultiAlumno", listaAlumnos);
            return View("MultiAlumno", _context.Alumnos);
        }
        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }

        
    }
}