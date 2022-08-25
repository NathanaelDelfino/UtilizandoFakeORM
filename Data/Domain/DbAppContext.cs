using FakeOrm.AzureTables.Configurations;
using FakeOrm.AzureTables.Repositories;
using TestFakeOrm.Domain;
using UtilizandoFakeORM.Data;
using UtilizandoFakeORM.Data.Domain;

namespace TestFakeOrm.Data.Domain
{
    public class DbAppContext : IDbAppContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected ConnectionStrings _connectionStrings;

        public DbAppContext()
        {
            _connectionStrings = new ConnectionStrings();
            _connectionStrings.AzureTableConnection = "DefaultEndpointsProtocol=https;AccountName=caprojetodeestudoeastus;AccountKey=j5YCrR6yXvxHf7dNK3JGvJg4yoozUCkeqqgtNYTAhPYmNoElafI6nMrh6XxEgcFLnnv/5nM1F5rz+AStuq6c5A==;EndpointSuffix=core.windows.net";
        }

        public void SaveChanges()
        {
            // var propertis = this;
            // foreach (var item in propertis.GetType().GetProperties())
            // {
            //     var dbSet = item.GetType(propertis);
            //     var repository = new AzureTableRepository<dbSet>(_connectionStrings);
            //     foreach (var entity in ((DbSet<dbSet>)dbSet).Get())
            //         repository.CreateOrUpdateAsync(entity);
            // }

            if (Produtos != null)
            {
                var repository = new AzureTableRepository<Produto>(_connectionStrings);
                foreach (var item in Produtos.Get())
                    repository.CreateOrUpdateAsync(item);
            }
            if (Clientes != null)
            {
                var repository = new AzureTableRepository<Cliente>(_connectionStrings);
                foreach (var item in Produtos.Get())
                    repository.CreateOrUpdateAsync(item);
            }


        }
    }
}