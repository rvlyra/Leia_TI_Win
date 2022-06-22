using livraria.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

/*
    Conexão Alternativa
*/
// Variáveis de ambiente do container
var server = builder.Configuration["DbServer"] ?? "GZTVIX-BDHM01";
// var port = builder.Configuration["DbPort"] ?? "1433"; -- usar em caso de conexão via docker
var user = builder.Configuration["DbUser"] ?? "estudos";
var password = builder.Configuration["DbPassword"] ?? "estudosdb@!123$";
var database = builder.Configuration["Database"] ?? "estudos";

var connectionString = $"Server={server};Initial Catalog={database};Password={password};User ID={user};Persist Security Info=True;";

//var conexao = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>( options => 
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


app.UseHttpsRedirection { get; }

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
