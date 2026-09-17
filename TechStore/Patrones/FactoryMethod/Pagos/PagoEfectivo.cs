namespace TechStore.Patrones.FactoryMethod.Pagos;

public class PagoEfectivo : IPago
{
    public void Procesar(decimal total)
    {
        Console.WriteLine($"Procesando pago en efectivo por un total de: {total:C}");
    }
}