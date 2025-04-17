namespace InventarioTI.Model
{
    public class Produto
    {
        public int Id { get; set; } = 0;
        public int IdMarca { get; set; } = 0;
        public int IdModelo { get; set; } = 0;
        public int IdSituacao { get; set; } = 0;
        public string CodigoDeFabrica { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public Decimal Preco { get; set; }
    }
}