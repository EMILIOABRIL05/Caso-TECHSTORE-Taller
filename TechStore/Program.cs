using core;
using Patrones.FactoryMethod.Notificaciones;
using TechStore.Patrones.FactoryMethod.Notificaciones;
using TechStore.Patrones.FactoryMethod.Reportes;

namespace TechStore
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n--- EJERCICIO 1 y 2 : Factory Method (NOTIFICACIONES) ---");
          Console.WriteLine("Bienvenido a TechStore");
          Console.WriteLine("Ejercicion 1:Factory Method (NOTIFICACIONES)");
           
           PedidoService servicio = new PedidoService();

           Console.WriteLine("\n[Ejemplo 1: Notificación por email]");
           NotificacionFactory emailFactory = new EmailFactory();

           servicio.CrearPedido("Juan", "Laptop", 1500.00m, emailFactory, "normal", "Calle 123");
           
           Console.WriteLine("\n[Ejemplo 2: Notificación por sms]");
           NotificacionFactory smsFactory = new SmsFactory();

           servicio.CrearPedido("Juan", "Laptop", 1500.00m, smsFactory, "normal", "Calle 123");
           Console.WriteLine("\n[Ejemplo 3: Notificación por WhatsApp]");
           NotificacionFactory whatsAppFactory = new WhatsAppFactory();

           servicio.CrearPedido("Juan", "Laptop", 1500.00m, whatsAppFactory, "normal", "Calle 123");


           Console.WriteLine("\n--- EJERCICIO 3: Factory Method (REPORTES) ---");

            ReporteFactory factoryPdf = new ReportePdfFactory();
            IReporte reportePdf = factoryPdf.GenerarReporte();
            reportePdf.Reportar();

            ReporteFactory factoryExcel = new ReporteExcelFactory();
            IReporte reporteExcel = factoryExcel.GenerarReporte();
            reporteExcel.Reportar();

            ReporteFactory factoryCsv = new ReporteCsvFactory();
            IReporte reporteCsv = factoryCsv.GenerarReporte();
            reporteCsv.Reportar();
                    
           
           
        }
    }
}