using FakeOrm.AzureTables.Configurations;
using FakeOrm.AzureTables.Domain;
using FakeOrm.AzureTables.Repositories;
using TestFakeOrm.Domain;
using TestFakeORM.Domain;
using UtilizandoFakeORM.Data;
using UtilizandoFakeORM.Data.Domain;

namespace TestFakeOrm.Data.Domain
{
    public class DbAppContext : IDbAppContext
    {
        private DbSet<Produto> _produtos;
        private DbSet<Cliente> _clientes;
        public DbSet<Funcionario> _funcionarios;

        public DbSet<Produto> Produtos => (this._produtos ??= new DbSet<Produto>());
        public DbSet<Cliente> Clientes => (this._clientes ??= new DbSet<Cliente>());
        public DbSet<Funcionario> Funcionarios => (this._funcionarios ??= new DbSet<Funcionario>());

        protected ConnectionStrings _connectionStrings;

        public DbAppContext()
        {
            _connectionStrings = new ConnectionStrings();
            _connectionStrings.AzureTableConnection = "DefaultEndpointsProtocol=https;AccountName=caprojetodeestudoeastus;AccountKey=j5YCrR6yXvxHf7dNK3JGvJg4yoozUCkeqqgtNYTAhPYmNoElafI6nMrh6XxEgcFLnnv/5nM1F5rz+AStuq6c5A==;EndpointSuffix=core.windows.net";
        }

        public void SaveChanges()
        {
            if (_produtos != null) _produtos.Save(_connectionStrings);
            if (_clientes != null) _clientes.Save(_connectionStrings);
            if (_funcionarios != null) _funcionarios.Save(_connectionStrings);           
        }
    }
}