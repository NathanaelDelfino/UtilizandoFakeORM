using FakeOrm.AzureTables.Domain;

namespace UtilizandoFakeORM.Data
{
    public interface IDbAppContext
    {
         void Save(BaseEntity entity);
    }
}