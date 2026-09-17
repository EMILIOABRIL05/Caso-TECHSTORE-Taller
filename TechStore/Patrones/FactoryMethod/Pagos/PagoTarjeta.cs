namespace TechStore.Patrones.FactoryMethod.Pagos;


public class PagoTarjeta : IPago
{
    public void Procesar(decimal total)
    {
        Console.WriteLine($"Procesando pago con tarjeta por un monto de {total:C}");
    }
}