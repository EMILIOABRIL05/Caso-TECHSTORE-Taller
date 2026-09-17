using TechStore.Core;

namespace TechStore.Patrones.Builder;
public class PedidoBuilder
{
    private readonly Pedido _pedido = new Pedido();


    public PedidoBuilder ConCliente(string cliente)
    {
        _pedido.Cliente = cliente;
        return this;
    }
    public PedidoBuilder ConProducto(string producto)
    {
        _pedido.Producto = producto;
        return this;
    }

    public PedidoBuilder ConPrecio(decimal precio)
    {
        _pedido.Precio = precio;
        return this;
    }


    public PedidoBuilder ConDireccion(string direccion)
    {
        _pedido.Direccion = direccion;
        return this;

    }


    public PedidoBuilder ConTelefono(string telefono)
    {
        _pedido.Telefono = telefono;
        return this;
    }
    public PedidoBuilder ConEntrega(string tipoEntrega)
    {
        _pedido.TipoEntrega=tipoEntrega;
        return this;
    }

    public PedidoBuilder RequiereFactura(bool requiere= true)
    {
        _pedido.RequiereFactura = requiere;
        return this;
    }
  
    public Pedido Construir()
    {
        return _pedido;
    }

}