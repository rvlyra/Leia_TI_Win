using Microsoft.EntityFrameworkCore;

namespace livraria.Models
{
    public class AppDbContexto : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContexto>)
    }
}