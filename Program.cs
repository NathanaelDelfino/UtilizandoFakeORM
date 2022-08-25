using TestFakeOrm.Data.Domain;
using UtilizandoFakeORM.Data;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IDbAppContext, DbAppContext>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
app.UseHttpsRedirection();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();


app.MapGet("/", context => Task.Run(() => context.Response.Redirect("/swagger/index.html")));

app.Run();
