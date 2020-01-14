using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Platzi_Asp_Net_core.Models {
    public class Curso : ObjetoEscuelaBase {
        [Required]
        [StringLength(5)]
        public override string Nombre { get; set; }

        [Required]
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }

        [Required(ErrorMessage="Se requiere una direccion")]
        [MinLength(10,ErrorMessage="La longitud minima es de 10")]
        public string Dirección { get; set; }
        public string EscuelaId { get; set; }
        public Escuela Escuela { get; set; }

    }
}