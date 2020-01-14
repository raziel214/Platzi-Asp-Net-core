using System;
using System.Collections.Generic;
using Platzi_Asp_Net_core.Models;
namespace Platzi_Asp_Net_core.Models {

    public class Asignatura : ObjetoEscuelaBase
    {
        public string CursoId { get; set; }
        public Curso Curso { get; set; }

        public List<Evaluación> Evaluaciones { get; set; }
    }
}