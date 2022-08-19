using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeOrm.AzureTables.Domain;
using FakeOrm.AzureTables.Repositories;
using FakeOrm.AzureTables.Repositories.Interface;
using TestFakeOrm.Data.Domain;
using TestFakeOrm.Domain;

namespace UtilizandoFakeORM.Data
{
    public class DbAppContextProduto : DbAppContext
    {
        private readonly IAzureTableRepository<Produto> _produtoRepository;
        public DbAppContextProduto()
        {
            _produtoRepository = new AzureTableRepository<Produto>(_connectionStrings);
        }

        public override List<Produto> Carregar<Produto>(int id)
        {
            return (List<Produto>)_produtoRepository.GetAsync().Result;
        }

        public override List<Produto> Carregar<Produto>()
        {

            var lista = _produtoRepository.GetAsync(x => x.CodigoBarras != "").Result;
            return (List<Produto>)lista;
        }

        public override void Save(BaseEntity entity)
        {
            _produtoRepository.CreateOrUpdateAsync((Produto)entity);
        }
    }
}