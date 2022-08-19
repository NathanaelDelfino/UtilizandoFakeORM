using FakeOrm.AzureTables.Domain;

namespace UtilizandoFakeORM.Data
{
    public interface IDbAppContext
    {
        void Save(BaseEntity entity);
        List<T> Carregar<T>(int id);
        List<T> Carregar<T>();
    }
}