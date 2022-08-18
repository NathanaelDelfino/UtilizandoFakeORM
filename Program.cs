using FakeOrm.AzureTables.DependencyInjection;
using FakeOrm.AzureTables.Repositories;
using Microsoft.AspNetCore.Mvc;
using TestFakeOrm.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var repository = new DbAppContext(builder.Services);

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", context => Task.Run(() => context.Response.Redirect("/swagger/index.html")));

app.Run();
