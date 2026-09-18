using core;
using TechStore.Core;
using TechStore.Patrones.Builder;
using TechStore.Patrones.FactoryMethod.Notificaciones;
using TechStore.Patrones.FactoryMethod.Reportes;
using TechStore.Patrones.FactoryMethod.Pagos;
using TechStore.Patrones.Singleton;
using TechStore.Patrones.AbstractFactory.Ventas;
using TechStore.Patrones.AbstractFactory.Proveedores;
using TechStore.Patrones.AbstractFactory.Cloud;
using TechStore.Patrones.Prototype.Ejercicio17;
using TechStore.Patrones.Prototype.Ejercicio18;
using TechStore.Patrones.Prototype.Ejercicio19;

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

            Console.WriteLine("\n--- EJERCICIO 8: Builder (Paquete de Entrega) ---");

            PaqueteEntrega paqueteNormal = new PaqueteEntregaBuilder()
                .ConTipoCaja("Caja estándar")
                .ConProteccion("Burbuja")
                .ConSeguro(false)
                .ConEtiquetaFragil(false)
                .ConObservacion("Entrega normal")
                .Construir();

            PaqueteEntrega paquetePremium = new PaqueteEntregaBuilder()
                .ConTipoCaja("Caja premium reforzada")
                .ConProteccion("Espuma + burbuja")
                .ConSeguro(true)
                .ConEtiquetaFragil(true)
                .ConObservacion("Entrega prioritaria con seguimiento")
                .Construir();

            Console.WriteLine("\n[Paquete NORMAL]");
            Console.WriteLine(paqueteNormal);

            Console.WriteLine("\n[Paquete PREMIUM]");
            Console.WriteLine(paquetePremium);


            Console.WriteLine("\n--- EJERCICIO 9: Singleton (Bitácora única del sistema) ---");

        
            Bitacora.Instancia.Registrar("Pedido de Ana (Libro) creado correctamente.");
            Bitacora.Instancia.Registrar("Computadora gaming configurada y lista.");
            Bitacora.Instancia.Registrar("Paquete PREMIUM preparado para envío.");

          

            Console.WriteLine("\n--- EJERCICIO 10: Singleton (Comprobar que existe una sola Bitacora) ---");
            Bitacora bitacora1 = Bitacora.Instancia;
            Bitacora bitacora2 = Bitacora.Instancia;
            Console.WriteLine(ReferenceEquals(bitacora1, bitacora2));

            Console.WriteLine("\n--- EJERCICIO 11: Singleton (Configuración global de TechStore) ---");
            ConfiguracionApp.Instancia.Configurar("TechStore", "USD", "Producción");
            Console.WriteLine($"Tienda: {ConfiguracionApp.Instancia.NombreTienda}");
            Console.WriteLine($"Moneda: {ConfiguracionApp.Instancia.Moneda}");
            Console.WriteLine($"Ambiente: {ConfiguracionApp.Instancia.Ambiente}");

            ConfiguracionApp otraVista = ConfiguracionApp.Instancia;
            Console.WriteLine($"Desde otra vista: {otraVista.NombreTienda} | {otraVista.Moneda} | {otraVista.Ambiente}");

            Console.WriteLine("\n--- EJERCICIO 12: Singleton (Contador global de pedidos) ---");
            ContadorPedidos.Instancia.Incrementar();
            Console.WriteLine($"Pedido 1: {ContadorPedidos.Instancia.Total}");

            ContadorPedidos.Instancia.Incrementar();
            Console.WriteLine($"Pedido 2: {ContadorPedidos.Instancia.Total}");

            ContadorPedidos.Instancia.Incrementar();
            Console.WriteLine($"Pedido 3: {ContadorPedidos.Instancia.Total}");

            Console.WriteLine("\n--- EJERCICIO 13: Abstract Factory (Familias NORMAL y PREMIUM) ---");

            Console.WriteLine("\n[Familia NORMAL]");
            IVentaFactory ventaNormal = new VentaNormalFactory();
            IEntrega entregaNormal = ventaNormal.CrearEntrega();
            IEmpaque empaqueNormal = ventaNormal.CrearEmpaque();
            entregaNormal.Entregar();
            empaqueNormal.Empacar();

            Console.WriteLine("\n[Familia PREMIUM]");
            IVentaFactory ventaPremium = new VentaPremiumFactory();
            IEntrega entregaPremium = ventaPremium.CrearEntrega();
            IEmpaque empaquePremium = ventaPremium.CrearEmpaque();
            entregaPremium.Entregar();
            empaquePremium.Empacar();

            Console.WriteLine("\n--- EJERCICIO 14: Abstract Factory (Familia CORPORATIVA) ---");
            Console.WriteLine("\n[Familia CORPORATIVA]");
            IVentaFactory ventaCorporativa = new VentaCorporativaFactory();
            IEntrega entregaCorporativa = ventaCorporativa.CrearEntrega();
            IEmpaque empaqueCorporativo = ventaCorporativa.CrearEmpaque();
            entregaCorporativa.Entregar();
            empaqueCorporativo.Empacar();

            Console.WriteLine("\n--- EJERCICIO 15: Abstract Factory (Proveedores DELL y LENOVO) ---");

            Console.WriteLine("\n[Familia DELL]");
            IProveedorFactory dellFactory = new DellFactory();
            ILaptop dellLaptop = dellFactory.CrearLaptop();
            IMonitor dellMonitor = dellFactory.CrearMonitor();
            dellLaptop.MostrarDetalle();
            dellMonitor.MostrarDetalle();

            Console.WriteLine("\n[Familia LENOVO]");
            IProveedorFactory lenovoFactory = new LenovoFactory();
            ILaptop lenovoLaptop = lenovoFactory.CrearLaptop();
            IMonitor lenovoMonitor = lenovoFactory.CrearMonitor();
            lenovoLaptop.MostrarDetalle();
            lenovoMonitor.MostrarDetalle();

            Console.WriteLine("\n--- EJERCICIO 16: Abstract Factory (Infraestructura Cloud) ---");

            Console.WriteLine("\n[FAMILIA AWS]");
            ICloudFactory awsFactory = new AwsFactory();
            IStorage awsStorage = awsFactory.CrearStorage();
            IQueue awsQueue = awsFactory.CrearQueue();
            awsStorage.Guardar();
            awsQueue.Publicar();

            Console.WriteLine("\n[FAMILIA AZURE]");
            ICloudFactory azureFactory = new AzureFactory();
            IStorage azureStorage = azureFactory.CrearStorage();
            IQueue azureQueue = azureFactory.CrearQueue();
            azureStorage.Guardar();
            azureQueue.Publicar();

            Console.WriteLine("\n--- EJERCICIO 17: Prototype (Clonar pedido base de laboratorio) ---");

            PedidoPrototype pedidoBase = new PedidoPrototype
            {
                Producto = "PC",
                Precio = 700,
                TipoEntrega = "NORMAL",
                RequiereFactura = true
            };

            PedidoPrototype pedido1 = pedidoBase.Clonar();
            pedido1.Cliente = "Carlos";
            pedido1.Direccion = "Laboratorio 1";

            PedidoPrototype pedido2 = pedidoBase.Clonar();
            pedido2.Cliente = "María";
            pedido2.Direccion = "Laboratorio 2";

            Console.WriteLine("\n[Pedido base]");
            Console.WriteLine(pedidoBase);
            Console.WriteLine("\n[Copia pedido1]");
            Console.WriteLine(pedido1);
            Console.WriteLine("\n[Copia pedido2]");
            Console.WriteLine(pedido2);

            Console.WriteLine("\n--- EJERCICIO 18: Prototype (Clonar configuración de computadora) ---");

            ComputadoraPrototype computadoraBase = new ComputadoraPrototype
            {
                NombreEquipo = "LAB-BASE",
                MemoriaRam = 16,
                Procesador = "Intel i5",
                DiscoGB = 512,
                TarjetaGrafica = "Gráficos integrados",
                SistemaOperativo = "Windows 11",
                TieneWifi = true
            };

            ComputadoraPrototype computadoraLabA = computadoraBase.Clonar();
            computadoraLabA.NombreEquipo = "LAB-A";
            computadoraLabA.MemoriaRam = 8;

            ComputadoraPrototype computadoraLabB = computadoraBase.Clonar();
            computadoraLabB.NombreEquipo = "LAB-B";
            computadoraLabB.MemoriaRam = 16;

            ComputadoraPrototype computadoraLabC = computadoraBase.Clonar();
            computadoraLabC.NombreEquipo = "LAB-C";
            computadoraLabC.MemoriaRam = 32;

            Console.WriteLine("\n[Computadora LAB-A]");
            Console.WriteLine(computadoraLabA);
            Console.WriteLine("\n[Computadora LAB-B]");
            Console.WriteLine(computadoraLabB);
            Console.WriteLine("\n[Computadora LAB-C]");
            Console.WriteLine(computadoraLabC);

            Console.WriteLine("\n--- EJERCICIO 19: Prototype (Datos internos independientes) ---");

            ServidorPrototype servidorOriginal = new ServidorPrototype
            {
                Nombre = "Servidor original",
                ConfiguracionRed = new ConfiguracionRed
                {
                    Ip = "192.168.1.10",
                    Puerto = 8080
                }
            };

            ServidorPrototype servidorCopia = servidorOriginal.Clonar();
            servidorCopia.Nombre = "Servidor copia";
            servidorCopia.ConfiguracionRed.Ip = "192.168.1.20";

            Console.WriteLine("\n[Servidor original]");
            Console.WriteLine(servidorOriginal);
            Console.WriteLine("\n[Servidor copia]");
            Console.WriteLine(servidorCopia);

            MenuPrincipal();
        }

        static void MenuPrincipal()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("              TECHSTORE                 ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Crear pedido NORMAL");
                Console.WriteLine("2. Crear pedido PREMIUM");
                Console.WriteLine("3. Crear pedido CORPORATIVO");
                Console.WriteLine("4. Crear pedido desde plantilla");
                Console.WriteLine("5. Probar notificaciones");
                Console.WriteLine("6. Probar Builder");
                Console.WriteLine("7. Mostrar contador de pedidos");
                Console.WriteLine("8. Mostrar configuración");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine() ?? string.Empty;
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        CrearPedidoIntegrado("NORMAL");
                        break;
                    case "2":
                        CrearPedidoIntegrado("PREMIUM");
                        break;
                    case "3":
                        CrearPedidoIntegrado("CORPORATIVO");
                        break;
                    case "4":
                        CrearPedidoDesdePlantilla();
                        break;
                    case "5":
                        ProbarNotificaciones();
                        break;
                    case "6":
                        ProbarBuilder();
                        break;
                    case "7":
                        Console.WriteLine($"Pedidos registrados: {ContadorPedidos.Instancia.Total}");
                        break;
                    case "8":
                        MostrarConfiguracion();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("\nPresione ENTER para volver al menú...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void CrearPedidoIntegrado(string modalidad)
        {
            Console.WriteLine($"--- Crear pedido {modalidad} ---");
            Pedido pedido = ConstruirPedido();
            pedido.TipoEntrega = modalidad;

            IVentaFactory ventaFactory = modalidad switch
            {
                "NORMAL" => new VentaNormalFactory(),
                "PREMIUM" => new VentaPremiumFactory(),
                _ => new VentaCorporativaFactory()
            };

            Console.WriteLine("\nPedido creado con Builder:");
            Console.WriteLine(pedido);
            ventaFactory.CrearEntrega().Entregar();
            ventaFactory.CrearEmpaque().Empacar();
            EnviarNotificacion();
            RegistrarPedido(pedido);
        }

        static void CrearPedidoDesdePlantilla()
        {
            Console.WriteLine("--- Crear pedido desde plantilla ---");
            PedidoPrototype plantilla = new PedidoPrototype
            {
                Producto = "PC",
                Precio = 700,
                TipoEntrega = "NORMAL",
                RequiereFactura = true
            };

            PedidoPrototype pedidoClonado = plantilla.Clonar();
            Console.WriteLine("Plantilla clonada correctamente.");

            Pedido pedido = new PedidoBuilder()
                .ConCliente(LeerTexto("Cliente: "))
                .ConProducto(pedidoClonado.Producto)
                .ConPrecio(pedidoClonado.Precio)
                .ConDireccion(LeerTexto("Dirección: "))
                .ConTelefono(LeerTexto("Teléfono: "))
                .ConEntrega(pedidoClonado.TipoEntrega)
                .RequiereFactura(pedidoClonado.RequiereFactura)
                .Construir();

            Console.WriteLine("\nPedido creado desde plantilla y completado con Builder:");
            Console.WriteLine(pedido);
            IVentaFactory ventaFactory = new VentaNormalFactory();
            ventaFactory.CrearEntrega().Entregar();
            ventaFactory.CrearEmpaque().Empacar();
            EnviarNotificacion();
            RegistrarPedido(pedido);
        }

        static Pedido ConstruirPedido()
        {
            return new PedidoBuilder()
                .ConCliente(LeerTexto("Cliente: "))
                .ConProducto(LeerTexto("Producto: "))
                .ConPrecio(LeerDecimal("Precio: "))
                .ConDireccion(LeerTexto("Dirección: "))
                .ConTelefono(LeerTexto("Teléfono: "))
                .RequiereFactura(LeerTexto("¿Requiere factura? (s/n): ").ToLower() == "s")
                .Construir();
        }

        static void ProbarBuilder()
        {
            Console.WriteLine("--- Prueba de Builder ---");
            Pedido pedido = ConstruirPedido();
            Console.WriteLine("\nPedido construido paso a paso:");
            Console.WriteLine(pedido);
        }

        static void EnviarNotificacion()
        {
            Console.WriteLine("\nSeleccione la notificación:");
            Console.WriteLine("1. Email");
            Console.WriteLine("2. SMS");
            Console.WriteLine("3. WhatsApp");
            Console.Write("Opción: ");

            NotificacionFactory factory = (Console.ReadLine() ?? string.Empty) switch
            {
                "1" => new EmailFactory(),
                "2" => new SmsFactory(),
                _ => new WhatsAppFactory()
            };

            factory.CrearNotificacion().Enviar();
        }

        static void ProbarNotificaciones()
        {
            Console.WriteLine("--- Prueba de Factory Method para notificaciones ---");
            EnviarNotificacion();
        }

        static void RegistrarPedido(Pedido pedido)
        {
            ContadorPedidos.Instancia.Incrementar();
            Bitacora.Instancia.Registrar($"Pedido de {pedido.Cliente} ({pedido.Producto}) registrado correctamente.");
            Console.WriteLine($"Pedido registrado. Total: {ContadorPedidos.Instancia.Total}");
        }

        static void MostrarConfiguracion()
        {
            ConfiguracionApp configuracion = ConfiguracionApp.Instancia;
            Console.WriteLine($"Tienda: {configuracion.NombreTienda}");
            Console.WriteLine($"Moneda: {configuracion.Moneda}");
            Console.WriteLine($"Ambiente: {configuracion.Ambiente}");
        }

        static string LeerTexto(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine() ?? string.Empty;
        }

        static decimal LeerDecimal(string mensaje)
        {
            while (true)
            {
                string valor = LeerTexto(mensaje);
                if (decimal.TryParse(valor, out decimal resultado))
                {
                    return resultado;
                }

                Console.WriteLine("Ingrese un precio válido.");
            }
        }
    }
}

 