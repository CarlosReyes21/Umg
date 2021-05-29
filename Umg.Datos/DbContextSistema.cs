using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Almacen;
using Umg.Entidades.Usuarios;
using Umg.Entidades.Ventas;

namespace Umg.Datos
{
   public class DbContextSistema :DbContext
    {
        public object articulo;

        public DbSet<categoria> articulo { get; set; }
        public DbSet<articulo> Articulos { get; set; }
        public DbSet<articulo_> Articulos_ { get; set; }

        public DbSet<persona_> Personas_ { get; set; }

        public DbSet<rol> Rols { get; set; }

        public DbSet<telefono_> Telefonos_ { get; set; }

        public DbSet<persona> Personas { get; set; }

        public DbSet<usuario_> Usuarios_ { get; set; }

        public DbSet<usuario> Usuarios { get; set; }

        public DbSet<detalleIngreso> DetallesIngresos { get; set; }

        public DbSet<detalleVenta> DetalleVentas { get; set; }

        public DbSet<Detalleventa_> Detalleventas_ { get; set; }
        public DbSet<ingreso> Ingresos { get; set; }

        public DbSet<ingreso_> Ingresos_ { get; set; }
        public DbSet<ventas> Ventass { get; set; }
        public DbSet<ventas_> Ventass_ { get; set; }


        public DbContextSistema(DbContextOptions<DbContextSistema> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMapp());
            modelBuilder.ApplyConfiguration(new ArticuloMapp());
            modelBuilder.ApplyConfiguration(new articulo_Mapp());
            modelBuilder.ApplyConfiguration(new PersonaMapp());
            modelBuilder.ApplyConfiguration(new Persona_Mapp());
            modelBuilder.ApplyConfiguration(new RolMapp());
            modelBuilder.ApplyConfiguration(new Telefono_Mapp());
            modelBuilder.ApplyConfiguration(new UsuarioMapp());
            modelBuilder.ApplyConfiguration(new Usuario_Mapp());
            modelBuilder.ApplyConfiguration(new DetalleIngresoMapp());
            modelBuilder.ApplyConfiguration(new DetalleVentaMapp());
            modelBuilder.ApplyConfiguration(new DetalleVenta_Mapp());
            modelBuilder.ApplyConfiguration(new IngresoMapp());
            modelBuilder.ApplyConfiguration(new Ingreso_Mapp());
            modelBuilder.ApplyConfiguration(new VentasMapp());
            modelBuilder.ApplyConfiguration(new Ventas_Mapp());


        }

    }
}