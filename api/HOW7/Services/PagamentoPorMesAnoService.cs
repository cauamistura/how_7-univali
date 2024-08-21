using HOW7.Model;
using HOW7.Model.Response;

namespace HOW7.Services
{
    public class PagamentoPorMesAnoService
    {
        public IList<PagamentosPorMesAnoJson> Executar()
        {
            var pagamentos = new PagamentoService().GetAll();
            var resultado = new List<PagamentosPorMesAnoJson>();

            pagamentos.GroupBy(pagamento => new {Mes = pagamento.Data.Month, Ano = pagamento.Data.Year})
                .ToList()
                .ForEach(grupo => AdicionarTotalPorMesAno(grupo, resultado));

            return resultado;
        }

        private void AdicionarTotalPorMesAno(IGrouping<object, PagamentoJson> grupo, List<PagamentosPorMesAnoJson> resultado)
        {
            var data = grupo.First().Data;
            var obj = new PagamentosPorMesAnoJson
            {
                Mes = data.Month,
                Ano = data.Year,
                Total = grupo.Sum(pagamento => pagamento.Valor)
            };
            resultado.Add(obj);
        }
    }
}
