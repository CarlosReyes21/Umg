using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Usuarios;

namespace Umg.Datos
{
    public class PersonaMapp : IEntityTypeConfigution<persona>
    {
        public void Configure(EntityTypeBuilder<persona> builder)
        {
            builder.ToTable("persona")
                  .HasKey(p => p.idPersona);
            builder.Property(p => p.idTelefono);
            builder.Property(p => p.nombrePersona)
                .HasMaxLength(50);
            builder.Property(p => p.numeroDeDocumento);
            builder.Property(p => p.emailPersona)
                .HasMaxLength(50);


        }
    }
}