using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Almacen
{
    public class articulo
    {
        public int idArticulo { get; set; }


        public int idCodigoArticulo { get; set; } // llave foranea


        public int idCategoria { get; set; } // llave foranea


        public String nombreArticulo { get; set; }
        [required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "el articulo no debe de tener mas de 50 caracteres, por favor validar")]

        public String descripcionArticulo { get; set; }
        [required]
        [StringLength(256, MinimumLength = 3, ErrorMessage = "la descripcion no debe de tener mas de 256 caracteres, por favor validar")]

        public bool condicionArticulo { get; set; }




    }
}
