using Microsoft.EntityFrameworkCore;
using livraria.Models;

namespace livraria.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Livro>? Livros { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.();
        }

    }
}