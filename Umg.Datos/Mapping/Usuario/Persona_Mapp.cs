using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Usuarios;

namespace Umg.Datos
{
    public class Persona_Mapp : IEntityTypeConfigution<persona_>
    {
        public void Configure(EntityTypeBuilder<persona_> builder)
        {
            builder.ToTable("persona_")
                  .HasKey(pe => pe.idPersona_);
            builder.Property(pe => pe.idPersona);

            builder.Property(pe => pe.tipoDePersona)
                .HasMaxLength(50);
            builder.Property(pe => pe.tipoDocumento)
                .HasMaxLength(3);
            builder.Property(pe => pe.direccion)
               .HasMaxLength(50);


        }
    }
}