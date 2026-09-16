using core;
using TechStore.Patrones.FactoryMethod.Notificaciones;

namespace TechStore
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Bienvenido a TechStore");
          Console.WriteLine("Ejercicion 1:Factory Method (NOTIFICACIONES)");
           
           PedidoService servicio = new PedidoService();

           Console.WriteLine("\n[Ejemplo 1: Notificación por email]");
           NotificacionFactory emailFactory = new EmailFactory();

           servicio.CrearPedido("Juan", "Laptop", 1500.00m, emailFactory, "normal", "Calle 123");
           
           Console.WriteLine("\n[Ejemplo 2: Notificación por sms]");
           NotificacionFactory smsFactory = new SmsFactory();

           servicio.CrearPedido("Juan", "Laptop", 1500.00m, smsFactory, "normal", "Calle 123");
        }
    }
}