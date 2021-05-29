using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Usuarios;

namespace Umg.Datos
{
    public class Telefono_Mapp : IEntityTypeConfigution<telefono_>
    {
        public void Configure(EntityTypeBuilder<telefono_> builder)
        {
            builder.ToTable("telefono_")
                  .HasKey(t => t.idTelefono);
            builder.Property(t => t.idPersona);

            builder.Property(t => t.telefonoPersonal)
                .HasMaxLength(8);
            builder.Property(t => t.telefonoCasa)
                 .HasMaxLength(8);
            builder.Property(t => t.telefonoLaboral)
              .HasMaxLength(8);

        }
    }
}