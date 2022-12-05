using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
//esta es una prueba para trakear los cambios en GIT

namespace PrimerParcial.Models
{  
    public class Instructor
    {
        //[Range(1,10000,ErrorMessage ="El campo debe ser un número entre 1 y 10000")] 
        //[Required(ErrorMessage ="Debe ingresar el Id")]
        public int Id{get; set;}

        [Range(1,50000,ErrorMessage ="El campo debe ser un número entre 1 y 5000")]
        //[Required(ErrorMessage ="Debe ingresar el Legajo de Vuelo")]
        public int LegajoVuelo {get; set;}
        
        //[Required(ErrorMessage ="Debe ingresar el Nombre")]
        public string Nombre {get; set;}

        //[Required(ErrorMessage ="Debe ingresar el Apellido")]
        public string Apellido {get; set;}

        //[Required(ErrorMessage ="Debe ingresar el DNI")]
        public int DNI {get; set;}
        public DateTime FechaExpedicion {get; set;}
        [Range(1,3)]
        public int Tra{get; set;}

        public int Hangar{get; set;}
        
        public bool EnActividad {get; set;}
    }
}
