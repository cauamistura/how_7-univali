namespace HOW7.Model
{
    public class PagamentoJson
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public decimal Valor { get; set; }

        public ImovelJson? Imovel { get; set; }
    }
}
