using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Usuarios
{
   public class persona
    {

        public int idPersona { get; set; }


        public int idTelefono { get; set; }


        public String nombrePersona { get; set; }
        [required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "el apartado persona no debe de tener mas de 50 caracteres, por favor validar")]



        public int numeroDeDocumento { get; set; }
        [required]

        public String emailPersona { get; set; }
        [required]
        [DataType(DataType.EmailAddress)]




    }
}