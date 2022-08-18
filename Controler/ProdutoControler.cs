using FakeOrm.AzureTables.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using TestFakeOrm.Data;
using TestFakeOrm.Domain;

namespace TestFakeOrm.Controler
{
    [ApiController]
     [Route("v1")]
    public class ProdutoControler : ControllerBase
    {      
        [HttpGet]
        [Route("produto")]
        public IActionResult ObterListaDeProdutosCadastrados(DbAppContext repository)
        {
           try
           {
                var produto = new Produto("123456789", "Produto 1"); 
                repository.Save(produto);
                return Ok("Ok");
           }
           catch (System.Exception ex)
           {
                return BadRequest(ex.Message);
                throw;
           } 

        }
    }
}