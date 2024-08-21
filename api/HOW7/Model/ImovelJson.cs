namespace HOW7.Model
{
    public class ImovelJson
    {
        public int Id { get; set; }

        public string Descricao { get; set; } = string.Empty;

        // Para retorno o "tipo" vai levar apenas o "nome" abstraindo assim para quem consome o "objeto" tipo
        public string NomeTipo => Tipo?.Nome ?? string.Empty;
        internal TipoJson? Tipo { get; set; }
    }
}
