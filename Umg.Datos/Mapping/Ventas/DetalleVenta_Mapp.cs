using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Ventas;

namespace Umg.Datos
{
    public class DetalleVenta_Mapp : IEntityTypeConfigution<Detalleventa_>
    {
        public void Configure(EntityTypeBuilder<Detalleventa_> builder)
        {
            builder.ToTable("Detalleventa_")
                  .HasKey(det => det.idDetalleventa_);
            builder.Property(det => det.idDetalleVenta);

            builder.Property(det => det.precioVenta);

            builder.Property(det => det.descuentoVenta);

        }
    }
}