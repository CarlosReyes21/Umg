using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Usuarios
{
   public class persona_
    {
        public int idPersona_ { get; set; }


        public int idPersona { get; set; }
        public String tipoDePersona { get; set; }
        [required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "el tipo de persona no debe de tener mas de 50 caracteres, por favor validar")]

        public String tipoDocumento { get; set; }
        [required]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "el tipo de documento no debe de tener mas de 3 caracteres, por favor validar")]

        public String direccion { get; set; }
        [required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "la direccion no debe de tener mas de 50 caracteres, por favor validar")]
    }
}
