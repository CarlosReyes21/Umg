using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.Almacen
{
    public class articulo_
    {
        public int idCodigoArticulo { get; set; }
        [required]

        public float precioArticulo { get; set; }
        [requiered]

        public int stock { get; set; }



    }
}