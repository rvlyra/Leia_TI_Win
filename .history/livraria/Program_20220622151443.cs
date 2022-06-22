using livraria.Models;
using livraria.Models.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

/*
    Conexão Alternativa
// Variáveis de ambiente do container
*/
var server = builder.Configuration["DbServer"] ?? "localhost";
var port = builder.Configuration["DbPort"] ?? "1433"; // usar em caso de conexão via docker
var user = builder.Configuration["DbUser"] ?? "sa";
var password = builder.Configuration["DbPassword"] ?? "Local@1234";
var database = builder.Configuration["Database"] ?? "LivrosDb";

// var connectionString = $"Server={server},{port};Initial Catalog={database};Password={password};User ID={user};Persist Security Info=True;";

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContexto>( options => 
    options.UseSqlServer(connectionString)
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
// Usar em linux
DatabaseManagementService.MigrationInitialisation(app);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
