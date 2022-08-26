using FakeOrm.AzureTables.Domain;

namespace TestFakeORM.Domain
{
    public class Funcionario : BaseEntity
    {
        public Funcionario()
        {

        }

        public Funcionario(string nome, string cargo)
        {
            Id = Guid.NewGuid().ToString();
            Nome = nome;
            Cargo = cargo;
        }

        public Funcionario(string id, string nome, string cargo)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
        }

        public string Id { get; private set; }
        public string Nome { get; private set; }
        public string Cargo { get; private set; }
    }
}
