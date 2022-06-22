using livraria.Models;
using Microsoft.EntityFrameworkCore;
namespace livraria.Models.Services
{
    public static class DatabaseManagementService
    {
        public static class MigrationInitialisation(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var serviceDb = serviceScope.ServiceProvider.GetService<AppDbContext>();
                // O método criará o banco e as tabelas, caso ainda não existam.
                serviceDb.Database.Migrate();
            }

        }
        
    }
}