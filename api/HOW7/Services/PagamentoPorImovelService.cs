using HOW7.Model;
using HOW7.Model.Response;

namespace HOW7.Services
{
    public class PagamentoPorImovelService
    {
        public IList<PagamentosPorImovelJson> Executar()
        {
            var pagamentos = new PagamentoService().GetAll();
            var resultado = new List<PagamentosPorImovelJson>();

            pagamentos.GroupBy(pagamento => pagamento.Imovel?.Id)
                .ToList()
                .ForEach(grupo => AdicionarTotalPorImovel(grupo, resultado));

            return resultado;
        }

        private void AdicionarTotalPorImovel(IGrouping<int?, PagamentoJson> pagamentosPorImovel, List<PagamentosPorImovelJson> imoveis)
        {
            var imovelComTotal = new PagamentosPorImovelJson
            {
                Imovel = pagamentosPorImovel.First().Imovel,
                Total = pagamentosPorImovel.Sum(pagamento => pagamento.Valor)
            };

            imoveis.Add(imovelComTotal);
        }
    }
}
