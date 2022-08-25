using FakeOrm.AzureTables.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using TestFakeOrm.Data;
using TestFakeOrm.Data.Domain;
using TestFakeOrm.Domain;
using UtilizandoFakeORM.Data;

namespace TestFakeOrm.Controler
{
    [ApiController]
    [Route("v1")]
    public class ProdutoControler : ControllerBase
    {
        DbAppContext _repository;

        public ProdutoControler(DbAppContext repository)
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
                _repository.Produtos.Add(produto);
                _repository.SaveChanges();
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

                //_repository.Produto.Add();
                //_repository.SaveChanges();
                //return Ok(lista);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
    }
}