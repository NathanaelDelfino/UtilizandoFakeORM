using TestFakeOrm.Data;
using TestFakeOrm.Domain;
using UtilizandoFakeORM.Data;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddTransient<IDbAppContext, DbAppContext>();
//builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();


app.MapPost("/produto", () =>
{
    try
    {
        var produto = new Produto("123456789", "Produto 1");
        produto.AlterarPrecoDeVenda(10.50f);
        var repository = new DbAppContextProduto();
        repository.Save(produto);
        return Results.Ok("Ok");
    }
    catch (System.Exception ex)
    {
        return Results.BadRequest(ex.Message);
        throw;
    }
});

app.MapGet("/produto", () =>
{
    try
    {
        var repository = new DbAppContextProduto();
        var lista = repository.Carregar<Produto>();
        return Results.Ok(lista);

    }
    catch (System.Exception ex)
    {
        return Results.BadRequest(ex.Message);
        throw;
    }
});
app.MapGet("/", context => Task.Run(() => context.Response.Redirect("/swagger/index.html")));

app.Run();
