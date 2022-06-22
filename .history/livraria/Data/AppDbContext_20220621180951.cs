using Microsoft.EntityFrameworkCore;
using livraria.Models;

namespace Livros.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Livro>? Livros {get;set;}
    }
}