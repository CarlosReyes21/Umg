using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Ventas
{
   public class detalleVenta
    {
        public int idDetalleVenta { get; set; }

        public int idArticulo { get; set; } //forenea

        public int idVenta { get; set; } // forenea

        public String cantidadVentas { get; set; }
        [required]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "la cantidad de ventas no debe de tener mas de 10 caracteres, por favor validar")]


    }
}