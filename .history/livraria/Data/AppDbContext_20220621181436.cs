using Microsoft.EntityFrameworkCore;
using livraria.Models;

namespace livraria.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Livro>? Livros { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(connectionString:"Initial Catalog=estudosdb;Data Source=GZTVIX-BDHM01;Password=estudosdb@!123$;Persist Security Info=True;User ID=estudosdb;");
        }

    }
}