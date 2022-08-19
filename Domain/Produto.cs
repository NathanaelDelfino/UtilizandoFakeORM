using FakeOrm.AzureTables.Domain;

namespace TestFakeOrm.Domain
{
    public class Produto : BaseEntity
    {
        public int Id { get; private set; }
        public string CodigoBarras { get; private set; } = "";
        public string Descricao { get; private set; } = "";
        public decimal PrecoDeVenda { get; private set; }
        
        public Produto()
        {
            
        }

        public Produto(string codigoBarras, string descricao)
        {
            CodigoBarras = codigoBarras;
            Descricao = descricao;
        }

        public Produto(int id, string codigoBarras, string descricao)
        {
            Id = id;
            CodigoBarras = codigoBarras;
            Descricao = descricao;
        }

        public Produto(int id, string codigoBarras, string descricao, decimal precoDeVenda)
        {
            Id = id;
            CodigoBarras = codigoBarras;
            Descricao = descricao;
            PrecoDeVenda = precoDeVenda;
        }

        public void AlterarPrecoDeVenda(decimal precoDeVenda)
        {
            PrecoDeVenda = precoDeVenda;
        }
    }
}