using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
namespace livraria.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Livro>? Livros {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString:"");
        }

        /*
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }
            public DbSet<Livro>? Livros {get;set;}
        */
    }
}