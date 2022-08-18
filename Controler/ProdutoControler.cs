using Microsoft.AspNetCore.Mvc;

namespace TestFakeOrm.Controler
{
    [ApiController]
    [Route("[v1]")]
    public class ProdutoControler : ControllerBase
    {
        [HttpGet]
        [Route("produto")]
        public IActionResult ObterListaDeProdutosCadastrados()
        {

           return Ok("Ok");
        }
    }
}