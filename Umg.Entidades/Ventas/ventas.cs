using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Ventas
{
    public class ventas
    {
        public int idVenta { get; set; }
        public int idUsuario { get; set; }
        public int idPersona { get; set; }

        public String serieComprobanteVenta { get; set; }
        [required]
        [StringLength(7, MinimumLength = 3, ErrorMessage = "la serie de comprobante no debe de tener mas de 7 caracteres, por favor validar")]



        public String numeroComprobanteventa { get; set; }
        [required]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "el numero comprobante de venta no debe de tener mas de 10 caracteres, por favor validar")]



        public DateTime fechaHora { get; set; }

    }
}