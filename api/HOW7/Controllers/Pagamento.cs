using HOW7.Model;
using HOW7.Services;
using Microsoft.AspNetCore.Mvc;

namespace HOW7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Pagamento : ControllerBase
    {

        [HttpGet]
        public IEnumerable<PagamentoJson> GetAll()
        {
            var resultado = new PagamentoService().GetAll();
            return resultado.ToArray();
        }
    }
}
