using Microsoft.EntityFrameworkCore;

namespace livraria.Models
{
    public class AppDbContexto : DbContext
    {
        public AppDbContexto(DbContextOptions<AppDbContexto> options) : base(options)
        {
        }
    }
}