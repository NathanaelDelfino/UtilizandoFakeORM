using FakeOrm.AzureTables.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using TestFakeOrm.Data;
using TestFakeOrm.Domain;
using UtilizandoFakeORM.Data;

namespace TestFakeOrm.Controler
{
    [ApiController]
    [Route("v1")]
    public class ProdutoControler : ControllerBase
    {
        // IDbAppContext _repository;

        // public ProdutoControler(IDbAppContext repository)
        // {
        //     _repository = repository;
        // }

        [HttpPost]
        [Route("produto")]
        public async Task<IActionResult> SalvarProduto()
        {
            try
            {
                var produto = new Produto("123456789", "Produto 1");
                produto.AlterarPrecoDeVenda(10.50m);
                var repository = new DbAppContextProduto();
                repository.Save(produto);
                return Ok("Ok");
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet]
        [Route("produto")]
        public async Task<IActionResult> ObterProdutos()
        {
            var repository = new DbAppContextProduto();
            var lista = repository.Carregar<Produto>();
            return Ok(lista);
        }
    }
}