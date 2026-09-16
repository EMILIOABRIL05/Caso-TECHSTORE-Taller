using TechStore.Core;
using TechStore.Patrones.FactoryMethod.Notificaciones;


namespace core
{

public class PedidoService
{
   public void CrearPedido(string cliente, string producto, decimal precio, NotificacionFactory notificacionFactory,string tipoEntrega, string direccion)
        {
            Pedido pedido = new Pedido
            {
                Cliente = cliente,
                Producto = producto,
                Precio = precio,
                TipoEntrega = tipoEntrega,
                Direccion = direccion
            };


            INotificacion notificacion = notificacionFactory.CrearNotificacion();
            notificacion.Enviar();


        string  mensajeEntrega = tipoEntrega?.ToUpper() switch 
        {
            "NORMAL" => "Preparando entrega normal...",
            "EXPRESS" => "Preparando entrega express...",
            _ => "Tipo de entrega no válido."
           
        };
        Console.WriteLine(mensajeEntrega);

        }

      
    }
}