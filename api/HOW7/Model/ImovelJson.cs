namespace HOW7.Model
{
    public class ImovelJson
    {
        public int Id { get; set; }

        public TipoJson? Tipo { get; set; }    
        
        public string Descricao { get; set; } = string.Empty;
    }
}
