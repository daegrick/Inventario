namespace Entity
{
    public class ItemPatrimonio
    {
        public Guid Ide { get; set; }
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public DateTime DataAquisicao { get; set; }
        public string NumeroSerie { get; set; } = string.Empty;
        public Guid CategoriaIde { get; set; }
    }
}
