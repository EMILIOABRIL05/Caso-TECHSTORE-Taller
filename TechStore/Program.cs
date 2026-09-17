using core;
using TechStore.Patrones.FactoryMethod.Notificaciones;
using TechStore.Patrones.FactoryMethod.Reportes;
using TechStore.Patrones.FactoryMethod.Pagos;
using TechStore.Patrones.Builder;
using TechStore.Core;
using System.Text;

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

            Console.WriteLine("\n--- EJERCICIO 4: Factory Method (Métodos de Pago) ---");
            decimal montoEjemplo = 1250.50m;

            PagoFactory factoryTarjeta = new PagoTarjetaFactory();
            IPago pagoTarjeta = factoryTarjeta.CrearPago();
            pagoTarjeta.Procesar(montoEjemplo);

            PagoFactory factoryTransferencia = new PagoTransferenciaFactory();
            IPago pagoTransferencia = factoryTransferencia.CrearPago();
            pagoTransferencia.Procesar(montoEjemplo);

            PagoFactory factoryEfectivo = new PagoEfectivoFactory();
            IPago pagoEfectivo = factoryEfectivo.CrearPago();
            pagoEfectivo.Procesar(montoEjemplo);

            Console.WriteLine("\n--- EJERCICIO 5: Builder (Pedido paso a paso) ---");
             Console.WriteLine("\n--- EJERCICIO 6: Builder (Pedido minimo y completo) ---");
            Console.WriteLine("\n[Pedido mínimo: solo datos obligatorios]");
            Pedido pedidoMinimo = new PedidoBuilder()
            .ConCliente("Ana")
            .ConProducto("Libro")
            .ConPrecio(50)
            .Construir();

            Console.WriteLine(pedidoMinimo);

            Console.WriteLine("\n[Pedido completo: todos los campos disponibles]");
            Pedido pedidoCompleto = new PedidoBuilder()
            .ConCliente("Ana")
            .ConProducto("Libro")
            .ConPrecio(50)
            .ConDireccion("Ambato")
            .ConTelefono("09999999")
            .ConEntrega("EXPRESS")
            .RequiereFactura()
            .Construir();

            Console.WriteLine(pedidoCompleto);

            Console.WriteLine("\n--- EJERCICIO 7: Builder (Computadora) ---");

            Console.WriteLine("\n[Computadora de oficina]");
            Computadora computadoraOficina = new ComputadoraBuilder()
            .ConProcesador("Intel i5")
            .ConRam(16)
            .ConDisco(512)
            .ConTarjetaGrafica("Gráficos integrados")
            .ConSistemaOperativo("Windows 11 Home")
            .ConWifi()
            .Construir();

            Console.WriteLine(computadoraOficina);

            Console.WriteLine("\n[Computadora gaming]");
            Computadora computadoraGaming = new ComputadoraBuilder()
            .ConProcesador("Ryzen 7")
            .ConRam(32)
            .ConDisco(1000)
            .ConTarjetaGrafica("RTX 4070")
            .ConSistemaOperativo("Windows 11 Pro")
            .ConWifi()
            .Construir();

            Console.WriteLine(computadoraGaming);
        }
    }
}