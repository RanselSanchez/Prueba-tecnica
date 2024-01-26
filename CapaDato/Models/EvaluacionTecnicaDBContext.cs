
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.Models
{
    public class EvaluacionTecnicaDBContext : DbContext
    {
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Proyectos> proyectos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().Property(t => t.Cedula).HasMaxLength(35)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("Is_Cedula") { IsUnique = true}));

            modelBuilder.Entity<Usuario>().Property(t => t.Usuario_nombre).HasMaxLength(45)
               .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("Is_Usuario_nombre") { IsUnique = true }));


            modelBuilder.Entity<Usuario>().Property(t => t.Fecha_Nacimiento).IsRequired();

            modelBuilder.Entity<Role>().Property(t => t.nombre).HasMaxLength(30)
               .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("Is_nombre") { IsUnique = true }));


        }
    }
}
