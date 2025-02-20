using Microsoft.EntityFrameworkCore;

namespace TallerLinq.Models
{
    public class LibroDbContext : DbContext
    {
        public LibroDbContext(DbContextOptions<LibroDbContext> options)
            : base(options)
        {
        }

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Autor> Autores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>(b =>
            {
                b.ToTable("Autor", schema: "dbo");
            });

            modelBuilder.Entity<Libro>(b =>
            {
                b.ToTable("Libro", schema: "dbo");
            });
        }
    }
}
