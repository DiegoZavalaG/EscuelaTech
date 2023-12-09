using EscuelaTech.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EscuelaTech.Models;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("GestorEscolarConnection");

// Registrar servicios para la conexión
builder.Services.AddDbContext<TalentoContext>(options => options.UseSqlServer(connectionString));


builder.Services.AddDbContext<TalentoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TalentoContext")));




// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
