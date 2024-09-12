using HOW7.Model;
using HOW7.Model.Response;
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

        [HttpGet]
        [Route("PorImovel")]
        public IEnumerable<PagamentosPorImovelJson> PorImovel()
        {
            var resultado = new PagamentoPorImovelService().Executar();
            return resultado.ToArray();
        }

        [HttpGet]
        [Route("PorMesAno")]
        public IEnumerable<PagamentosPorMesAnoJson> PorMesAno()
        {
            var resultado = new PagamentoPorMesAnoService().Executar();
            return resultado.ToArray();
        }

        [HttpGet]
        [Route("PercentualPorTipoImovel")]
        public IEnumerable<TotalVendasPorTipoImovelJson> PercentualPorTipoImovel()
        {
            var resultado = new TotalVendasPorTipoImovelService().Executar();
            return resultado.ToArray();
        }
    }
}
