using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Ventas;

namespace Umg.Datos
{
    public class IngresoMapp : IEntityTypeConfigution<ingreso>
    {
        public void Configure(EntityTypeBuilder<ingreso> builder)
        {
            builder.ToTable("ingreso")

                  .HasKey(i => i.idIngreso);

            builder.Property(i => i.idProveedor);


            builder.Property(i => i.idUsuario);

            builder.Property(i => i.tipoComprobanteIngreso)
                 .HasMaxLength(50);

            builder.Property(i => i.serieComprobanteIngreso)
                .HasMaxLength(50);

            builder.Property(i => i.fechaHoraIngreso);

            builder.Property(i => i.impuestoIngreso);


        }
    }
}