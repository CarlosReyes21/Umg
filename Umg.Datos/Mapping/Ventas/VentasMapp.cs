using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Ventas;

namespace Umg.Datos
{
   public class VentasMapp : IEntityTypeConfigution<ventas>
    {
        public void Configure(EntityTypeBuilder<ventas> builder)
        {
            builder.ToTable("ventas")

                  .HasKey(v => v.idVenta);

            builder.Property(v => v.idUsuario);


            builder.Property(v => v.idPersona);

            builder.Property(v => v.serieComprobanteVenta)
                 .HasMaxLength(7);

            builder.Property(v => v.serieComprobanteVenta)
                .HasMaxLength(10);

            builder.Property(v => v.fechaHora);




        }
    }
}