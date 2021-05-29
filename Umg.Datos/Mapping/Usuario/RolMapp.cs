using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Usuarios;

namespace Umg.Datos
{
    public class RolMapp : IEntityTypeConfigution<rol>
    {
        public void Configure(EntityTypeBuilder<rol> builder)
        {
            builder.ToTable("rol")
                  .HasKey(r => r.idRol);
            builder.Property(r => r.nombreRol)
                .HasMaxLength(50);
            builder.Property(r => r.descripcionRol)
                .HasMaxLength(100);
            builder.Property(r => r.condicion);

        }
    }
}