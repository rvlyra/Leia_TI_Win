var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

/*
    Conexão Alternativa
*/

var server = builder.Configuration["DbServer"] ?? "BDHM01";
// var port = builder.Configuration["DbPort"] ?? "1433"; -- usar em caso de conexão via docker
var user = builder.Configuration["DbUser"] ?? "estudos";
var password = builder.Configuration["DbPassword"] ?? "estudosdb@!123$";
var database = builder.Configuration["Database"] ?? "estudos";


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
