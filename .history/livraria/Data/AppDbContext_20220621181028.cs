using Microsoft.EntityFrameworkCore;
using livraria.Models;

namespace livraria.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Livro>? Livros {get; set;}
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

    }
}