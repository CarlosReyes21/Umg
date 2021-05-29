using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Almacen;

namespace Umg.Datos
{
    public class CategoriaMapp : IEntityTypeConfiguration<categoria>
    {
        public void Configure(EntityTypeBuilder<categoria> builder)
        {
            builder.ToTable("categoria")
                  .HasKey(c => c.idCategoria);
            builder.Property(c => c.nombreCategoria)
                .HasMaxLength(50);
            builder.Property(c => c.descripcion)
                .HasMaxLength(256);
            builder.Property(c => c.condicion);

        }
    }
}