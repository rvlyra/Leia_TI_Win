using Microsoft.EntityFrameworkCore;

namespace livraria.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Livro>? Livros {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        /*
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }
            public DbSet<Livro>? Livros {get;set;}
        */
    }
}