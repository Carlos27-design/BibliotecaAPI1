using BibliotecaAPI.Enitities;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }

        public DbSet<Autor>Autores { get; set; }
        public DbSet<Libro>Libros { get; set; }
    }
}
