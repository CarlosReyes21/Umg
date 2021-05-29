using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Usuarios
{
    public class rol
    {
        public int idRol { get; set; }

        public String nombreRol { get; set; }
        [required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "el rol no debe de tener mas de 50 caracteres, por favor validar")]
        public String descripcionRol { get; set; }
        [required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "la descripcion no debe de tener mas de 100 caracteres, por favor validar")]
        public bool condicion { get; set; }




    }
}
