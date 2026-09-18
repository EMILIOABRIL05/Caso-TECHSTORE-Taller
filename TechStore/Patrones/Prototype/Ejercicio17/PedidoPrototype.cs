namespace TechStore.Patrones.Prototype.Ejercicio17;

public class PedidoPrototype
{
    public string Cliente { get; set; } = string.Empty;
    public string Producto { get; set; } = string.Empty;
    public decimal Precio { get; set; }
    public string Direccion { get; set; } = string.Empty;
    public string TipoEntrega { get; set; } = string.Empty;
    public bool RequiereFactura { get; set; }

    public PedidoPrototype Clonar()
    {
        return new PedidoPrototype
        {
            Cliente = Cliente,
            Producto = Producto,
            Precio = Precio,
            Direccion = Direccion,
            TipoEntrega = TipoEntrega,
            RequiereFactura = RequiereFactura
        };
    }

    public override string ToString()
    {
        return $"[PEDIDO PROTOTYPE]\n" +
               $"  Cliente:          {Cliente}\n" +
               $"  Producto:         {Producto}\n" +
               $"  Precio:           ${Precio:N2}\n" +
               $"  Dirección:        {Direccion}\n" +
               $"  Tipo de Entrega:  {TipoEntrega}\n" +
               $"  Factura:          {(RequiereFactura ? "Sí" : "No")}";
    }
}