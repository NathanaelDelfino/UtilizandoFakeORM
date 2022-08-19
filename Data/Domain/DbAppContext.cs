using FakeOrm.AzureTables.Configurations;
using FakeOrm.AzureTables.Domain;
using FakeOrm.AzureTables.Repositories;
using TestFakeOrm.Domain;
using UtilizandoFakeORM.Data;

namespace TestFakeOrm.Data.Domain
{
    public abstract class DbAppContext : IDbAppContext
    {
        protected ConnectionStrings _connectionStrings;

        public DbAppContext()
        {
            _connectionStrings = new ConnectionStrings();
            _connectionStrings.AzureTableConnection = "DefaultEndpointsProtocol=https;AccountName=caprojetodeestudoeastus;AccountKey=j5YCrR6yXvxHf7dNK3JGvJg4yoozUCkeqqgtNYTAhPYmNoElafI6nMrh6XxEgcFLnnv/5nM1F5rz+AStuq6c5A==;EndpointSuffix=core.windows.net";

        }

        public abstract List<T> Carregar<T>(int id);
        public abstract List<T> Carregar<T>();
        public abstract void Save(BaseEntity entity);
    }
}