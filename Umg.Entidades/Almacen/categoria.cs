using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Almacen
{
    public class categoria
    {
        public int idCategoria { get; set; }
        [Required]

        [StringLength(50, MinimumLength = 3, ErrorMessage = "el nombre no debe de tener mas de 50 caracteres, por favor validar")]

        public string nombreCategoria { get; set; }
        [Required]
        [StringLength(256)]


        public string descripcion { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "la descripcion no debe de tener mas de 50 caracteres, por favor validar")]

        public bool condicion { get; set; }




    }
}
