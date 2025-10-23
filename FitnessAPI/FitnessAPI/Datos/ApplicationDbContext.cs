using FitnessAPI.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FitnessAPI.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Entrenamiento> Entrenamientos { get; set; }
        public DbSet<Ejercicio> Ejercicios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
