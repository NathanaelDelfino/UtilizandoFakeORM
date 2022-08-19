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
        IDbAppContext _repository;

        public ProdutoControler(IDbAppContext repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("produto")]
        public IActionResult SalvarProduto()
        {
            try
            {
                var produto = new Produto("123456789", "Produto 1");
                produto.AlterarPrecoDeVenda(10.50f);
                //var repository = new DbAppContextProduto();
                _repository.Save(produto);
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
        public IActionResult ObterProdutos()
        {
            try
            {
                //var repository = new DbAppContextProduto();
                var lista = _repository.Carregar<Produto>();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
    }
}