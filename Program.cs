global using FIAP_MVC.Models;
global using FIAP_MVC.Data;
using Microsoft.EntityFrameworkCore;



//--------Tudo oq é de bilder/configuração do projeto projeto------------

var builder = WebApplication.CreateBuilder(args); //o biulder é quem vai trazer as funções iniciais para nosso programa

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataContext>(options =>//um serviço está sendo gerado quando chamamos a aplicação
{
    options.UseOracle(builder.Configuration.GetConnectionString("OracleConnection")); //conexão com o banco
});

var app = builder.Build(); //o app é quem vai executar tudo

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
