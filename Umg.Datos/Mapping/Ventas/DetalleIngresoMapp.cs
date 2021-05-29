using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Ventas;

namespace Umg.Datos
{
    public class DetalleIngresoMapp : IEntityTypeConfigution<detalleIngreso>
    {
        public void Configure(EntityTypeBuilder<detalleIngreso> builder)
        {
            builder.ToTable("detalleIngreso")
                  .HasKey(d => d.idDetalleIngreso);
            builder.Property(d => d.idIngreso);

            builder.Property(d => d.idArticulo);

            builder.Property(d => d.cantidadDetalleIngreso);
            builder.Property(d => d.precioDetalleIngreso);
        }
    }
}