using HOW7.Model;
using HOW7.Model.Response;

namespace HOW7.Services
{
    public class PagamentoVendasPorTipoImovelService
    {
        private IList<PagamentosVendasPorTipoImovelJson> _totalVendasPorTipoImovelJson { get; set; } = new List<PagamentosVendasPorTipoImovelJson>();

        public IList<PagamentosVendasPorTipoImovelJson> Executar()
        {
            _totalVendasPorTipoImovelJson.Clear();
            var pagamentos = new PagamentoService().GetAll();            
            var totalVendas = pagamentos.Count;

            var vendasPorImovel = pagamentos
                .GroupBy(pagamento => pagamento.Imovel?.Tipo?.Id)
                .ToList();

            vendasPorImovel.ForEach(grupo => 
                AdicionarTotalPorTipoImovel(grupo, totalVendas)
            );

            return _totalVendasPorTipoImovelJson;
        }

        private void AdicionarTotalPorTipoImovel(IGrouping<int?, PagamentoJson> pagamentosPorImovel, int totalVendas)
        {
            var imovelComTotal = new PagamentosVendasPorTipoImovelJson
            {
                Tipo = pagamentosPorImovel.First().Imovel?.Tipo,
                Total = (decimal)pagamentosPorImovel.Count() / totalVendas * 100
            };

            _totalVendasPorTipoImovelJson.Add(imovelComTotal);
        }
    }
}
