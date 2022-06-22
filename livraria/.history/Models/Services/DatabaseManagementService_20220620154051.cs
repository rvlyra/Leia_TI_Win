using livraria.Models;
using Microsoft.EntityFrameworkCore;
namespace livraria.Models.Services
{
    public static class DatabaseManagementService
    {
        public static void MigrationInitialization(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationService.CreateScope())
            {
                
            }

        }
        
    }
}