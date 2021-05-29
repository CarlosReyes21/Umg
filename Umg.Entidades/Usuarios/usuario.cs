using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Usuarios
{
    public class usuario
    {
        public int idUsuario { get; set; }


        public int idRol { get; set; }

        public int idTelefono { get; set; }
        public string nombreUsuario { get; set; }
        [required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "el nombre de usuario no debe de tener mas de 100 caracteres, por favor validar")]

        public int numeroDocumentoUsuario { get; set; }

        public string emailUsuario { get; set; }
        [required]

        [DataType(DataType.EmailAddress)]

        public byte passwordHash { get; set; }

        public byte passwordSalt { get; set; }



    }
}
