using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Ventas;

namespace Umg.Datos
{
    public class Ventas_Mapp : IEntityTypeConfigution<ventas_>
    {
        public void Configure(EntityTypeBuilder<ventas_> builder)
        {
            builder.ToTable("ventas_")

                  .HasKey(ve => ve.idVenta_);

            builder.Property(ve => ve.idVenta);



            builder.Property(ve => ve.tipoComprobanteVenta)
                 .HasMaxLength(50);

            builder.Property(ve => ve.impuesto);

            builder.Property(ve => ve.total);
            builder.Property(ve => ve.condicionVenta);


        }
    }
}