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
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "MyDb.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
            //optionsBuilder.UseSql(ConnectionString:"DataSource=app.db;Cache=shared");
        }

        /*
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }
            public DbSet<Livro>? Livros {get;set;}
        */
    }
}