namespace InventarioTI.Model
{
    public class Filtros
    {
        public int Marca { get; set; } = 0;
        public int Modelo { get; set; } = 0;
        public int Situacao { get; set; } = 0;
        public string Descricao { get; set; } = string.Empty;
        public float Preco { get; set; } = 0.0f;
    }
}