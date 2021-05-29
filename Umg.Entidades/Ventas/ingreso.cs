using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Ventas
{
    public class ingreso
    {
        public int idIngreso { get; set; }

        public int idProveedor { get; set; }
        public int idUsuario { get; set; }

        public String tipoComprobanteIngreso { get; set; }
        [required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "el tipo comprobante ingreso no debe de tener mas de 50 caracteres, por favor validar")]



        public String serieComprobanteIngreso { get; set; }
        [required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "la serie comprobante de ingreso no debe de tener mas de 50 caracteres, por favor validar")]



        public String numComprobante { get; set; }
        [required]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "el numero de comprobante  no debe de tener mas de 10 caracteres, por favor validar")]



        public DateTime fechaHoraIngreso { get; set; }
        [required]

        public decimal impuestoIngreso { get; set; }

    }
}