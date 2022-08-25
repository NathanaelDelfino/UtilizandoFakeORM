using FakeOrm.AzureTables.Domain;

namespace UtilizandoFakeORM.Data
{
    public interface IDbAppContext
    {
        //void Save(BaseEntity entity);
        void SaveChanges();
        // List<BaseEntity> Carregar(int id);
        // List<BaseEntity> Carregar();
    }
}