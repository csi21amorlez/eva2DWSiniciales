using DAL_eva2DWSiniciales.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//Creamos la conexion con el dbContext de nuestra base de datos db_evaluacion
builder.Services.AddDbContext<BdEvaluacionContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL")));

var app = builder.Build();

/*builder.Services.AddDbContext<CSPharmaContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL")));*/

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
