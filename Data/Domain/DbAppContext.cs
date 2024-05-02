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
            _connectionStrings.AzureTableConnection = "{Aqui vai sua conection string do Azure Table}";

        }

        public abstract List<T> Carregar<T>(int id);
        public abstract List<T> Carregar<T>();
        public abstract void Save(BaseEntity entity);
    }
}
