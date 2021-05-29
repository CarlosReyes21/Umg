using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Ventas;

namespace Umg.Datos
{
   public class Ingreso_Mapp : IEntityTypeConfigution<ingreso_>
    {
        public void Configure(EntityTypeBuilder<ingreso_> builder)
        {
            if (builder is null)
            {
                throw new System.ArgumentNullException(nameof(builder));
            }

            builder.ToTable("ingreso_")

                  .HasKey(i => i.idIngreso_);

            builder.Property(i => i.idIngreso);


            builder.Property(i => i.totalIngreso);

            builder.Property(i => i.condicion);



        }
    }
}