using System;
using System.Collections.Generic;

namespace Platzi_Asp_Net_core.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; } //= new List<Evaluación>();
    }
}