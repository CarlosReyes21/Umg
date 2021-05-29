using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Usuarios
{
   public class usuario_
    {
        public int idUsuario_ { get; set; }
        public int idUsuario { get; set; }

        public String direccionUsuario { get; set; }
        [required]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "la direccion del usuario no debe de tener mas de 70 caracteres, por favor validar")]

        public bool condicion { get; set; }
        [required]
    }
}
