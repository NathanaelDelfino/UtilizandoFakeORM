using FakeOrm.AzureTables.DependencyInjection;
using FakeOrm.AzureTables.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using TestFakeOrm.Data;
using TestFakeOrm.Domain;
using UtilizandoFakeORM.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IDbAppContext, DbAppContext>();
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();


app.MapGet("/produto", () =>
{
    try
    {
        var produto = new Produto("123456789", "Produto 1");
        
       var repository = new DbAppContext();
       repository.Save(produto);
        
        return Results.Ok("Ok");
    }
    catch (System.Exception ex)
    {
        return Results.BadRequest(ex.Message);
        throw;
    }
});
app.MapGet("/", context => Task.Run(() => context.Response.Redirect("/swagger/index.html")));

app.Run();
