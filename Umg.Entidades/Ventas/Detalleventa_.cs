using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.Ventas
{
    public class Detalleventa_
    {
        public int idDetalleventa_ { get; set; }

        public int idDetalleVenta { get; set; }

        public decimal precioVenta { get; set; }
        [required]

        public decimal descuentoVenta { get; set; }

    }
}