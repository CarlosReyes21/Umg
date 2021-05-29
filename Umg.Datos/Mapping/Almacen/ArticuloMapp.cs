using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Almacen;

namespace Umg.Datos
{

    public class ArticuloMapp : IEntityTypeConfigution<articulo>
    {
        public void Configure(EntityTypeBuilder<articulo> builder)
        {
            builder.ToTable("articulo")
                  .HasKey(a => a.idArticulo);


            builder.Property(a => a.idCodigoArticulo); // llave foranea
            builder.Property(a => a.idCategoria);

            builder.Property(a => a.nombreArticulo)
                .HasMaxLength(50);
            builder.Property(a => a.descripcionArticulo)
                .HasMaxLength(256);

            builder.Property(a => a.condicionArticulo);
        }
    }
}