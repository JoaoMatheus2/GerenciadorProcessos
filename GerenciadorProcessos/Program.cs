using GerenciadorProcessos.Data;
using GerenciadorProcessos.Repositorio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddDataAnnotationsLocalization();


builder.Services.AddEntityFrameworkSqlServer()
  .AddDbContext<BancoContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));
builder.Services.AddScoped<IProcessoRepositorio, ProcessoRepositorio>();

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
