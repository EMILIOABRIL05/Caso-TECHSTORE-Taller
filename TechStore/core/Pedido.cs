namespace TechStore.Core
{
    public class Pedido
    {
        public string Cliente { get; set; } = string.Empty;
        public string Producto { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public string Direccion { get; set; } = string.Empty;
        public string TipoEntrega { get; set; } = string.Empty;
    }
}