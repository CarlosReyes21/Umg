using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Almacen;

namespace Umg.Datos
{
    public class articulo_Mapp : IEntityTypeConfigution<articulo_>
    {
        public void Configure(EntityTypeBuilder<articulo_> builder)
        {
            builder.ToTable("articulo_")
                  .HasKey(ar => ar.idCodigoArticulo);
            builder.Property(ar => ar.precioArticulo);
            builder.Property(ar => ar.precioArticulo);



        }
    }
}