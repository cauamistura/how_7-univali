using HOW7.Model;
using HOW7.Model.Response;

namespace HOW7.Services
{
    public class TotalVendasPorTipoImovelService
    {
        public IList<TotalVendasPorTipoImovelJson> Executar()
        {
            var pagamentos = new PagamentoService().GetAll();
            var resultado = new List<TotalVendasPorTipoImovelJson>();

            var totalVendas = pagamentos.Count;

            var vendasPorImovel = pagamentos
                .GroupBy(pagamento => pagamento.Imovel?.Tipo)
                .ToList()
                .ForEach(grupo => AdicionarTotalPorTipoImovel(grupo, totalVendas, resultado));

            return resultado;
        }

        private void AdicionarTotalPorTipoImovel(
            IGrouping<TipoJson?, PagamentoJson> pagamentosPorImovel,
            int totalVendas,
            List<TotalVendasPorTipoImovelJson> imoveis)
        {
            var imovelComTotal = new TotalVendasPorTipoImovelJson
            {
                Tipo = pagamentosPorImovel.First().Imovel?.Tipo,
                Total = (decimal)pagamentosPorImovel.Count() / totalVendas * 100
            };

            imoveis.Add(imovelComTotal);
        }
    }
}
