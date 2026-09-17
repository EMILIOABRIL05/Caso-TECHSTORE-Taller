namespace TechStore.Core
{
    public class Pedido
    {
        public string Cliente { get; set; } = string.Empty;
        public string Producto { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Observacion { get; set; } = string.Empty;
        public string TipoEntrega { get; set; } = string.Empty;
        public bool RequiereFactura { get; set; } 


public override string ToString()
{
    return $"[PEDIDO]\n" +
           $"  Cliente:          {Cliente}\n" +
           $"  Producto:         {Producto}\n" +
           $"  Precio:           ${Precio:N2}\n" +
           $"  Dirección:        {Direccion}\n" +
           $"  Teléfono:         {Telefono}\n" +
           $"  Tipo de Entrega:  {TipoEntrega}\n" +
           $"  Factura:          {(RequiereFactura ? "Sí" : "No")}\n" +
           $"  Observación:      {(string.IsNullOrWhiteSpace(Observacion) ? "Ninguna" : Observacion)}";
}
    }
}