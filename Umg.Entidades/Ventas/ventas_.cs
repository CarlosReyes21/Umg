using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Ventas
{
   public class ventas_
    {
        public int idVenta_ { get; set; }

        public int idVenta { get; set; }

        public String tipoComprobanteVenta { get; set; }
        [required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "el tipo comprobante venta no debe de tener mas de 50 caracteres, por favor validar")]



        public decimal impuesto { get; set; }

        public decimal total { get; set; }

        public bool condicionVenta { get; set; }
    }
}