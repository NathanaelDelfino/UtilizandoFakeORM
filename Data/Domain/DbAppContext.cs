using FakeOrm.AzureTables.Configurations;
using FakeOrm.AzureTables.Repositories;
using TestFakeOrm.Domain;
using TestFakeORM.Domain;
using UtilizandoFakeORM.Data;
using UtilizandoFakeORM.Data.Domain;

namespace TestFakeOrm.Data.Domain
{
    public class DbAppContext : IDbAppContext
    {
        public DbSet<Produto> Produtos { get; set; } = new DbSet<Produto>();
        public DbSet<Cliente> Clientes { get; set; } = new DbSet<Cliente>();
        public DbSet<Funcionario> Funcionarios { get; set; } = new DbSet<Funcionario>();

        protected ConnectionStrings _connectionStrings;

        public DbAppContext()
        {
            _connectionStrings = new ConnectionStrings();
            _connectionStrings.AzureTableConnection = "DefaultEndpointsProtocol=https;AccountName=caprojetodeestudoeastus;AccountKey=j5YCrR6yXvxHf7dNK3JGvJg4yoozUCkeqqgtNYTAhPYmNoElafI6nMrh6XxEgcFLnnv/5nM1F5rz+AStuq6c5A==;EndpointSuffix=core.windows.net";
        }

        public void SaveChanges()
        {
            Clientes.Save(_connectionStrings);            
            Produtos.Save(_connectionStrings);            
            Funcionarios.Save(_connectionStrings);
        }
    }
}