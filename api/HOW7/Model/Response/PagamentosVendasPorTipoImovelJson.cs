namespace HOW7.Model.Response
{
    public class PagamentosVendasPorTipoImovelJson
    {
        public string NomeTipo => Tipo?.Nome ?? string.Empty;
        internal TipoJson? Tipo { get; set; }

        public decimal Total { get; set; }
    }
}
