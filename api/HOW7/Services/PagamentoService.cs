using HOW7.Connection;
using HOW7.Model;

namespace HOW7.Services
{
    public class PagamentoService
    {
        public IList<PagamentoJson> GetAll()
        {
            var pagamentos = new List<PagamentoJson>();
            var databaseService = new DatabaseService();

            using var reader = databaseService.ExecuteReader(QueryGetAll);
            while (reader.Read())
            {
                var pagamento = new PagamentoJson
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Data = reader.GetDateTime(reader.GetOrdinal("Data")),
                    Valor = reader.GetDecimal(reader.GetOrdinal("Valor")),
                    Imovel = new ImovelJson
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("imovelId")),
                        Descricao = reader.GetString(reader.GetOrdinal("imovelDescricao")),
                        Tipo = new TipoJson
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("tipoId")),
                            Nome = reader.GetString(reader.GetOrdinal("tipoNome"))
                        }
                    }
                };

                pagamentos.Add(pagamento);
            }

            return pagamentos;
        }

        private string QueryGetAll => @"
        SELECT 
            PAGAMENTO.Id, 
            PAGAMENTO.Data, 
            PAGAMENTO.Valor, 
            IMOVEL.ID AS imovelId, 
            IMOVEL.DESCRICAO AS imovelDescricao,
            TIPO.ID AS tipoId, 
            TIPO.NOME AS tipoNome
        FROM PAGAMENTOS PAGAMENTO
        JOIN IMOVEIS IMOVEL ON PAGAMENTO.IMOVEL = IMOVEL.ID 
        JOIN TIPOIMOVEIS TIPO ON IMOVEL.TIPO = TIPO.ID
        ORDER BY PAGAMENTO.IMOVEL";
    }
}