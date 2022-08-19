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
        public async Task<IActionResult> Post()
        {
           try
           {
                var produto = new Produto("123456789", "Produto 1"); 
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
        public IActionResult ObterListaDeProdutosCadastrados()
        {
            return Ok("Ok");
        }
    }
}