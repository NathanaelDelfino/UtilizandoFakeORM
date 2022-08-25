using FakeOrm.AzureTables.Domain;

namespace TestFakeOrm.Domain
{
    public class Cliente : BaseEntity
    {
        public Cliente(string nome)
        {
            Id = Guid.NewGuid().ToString("N");
            Nome = nome;
        }

        public Cliente(string id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public string Id { get; private set; }
        public string Nome { get; private set; }
    }
}