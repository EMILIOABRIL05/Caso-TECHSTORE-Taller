namespace TechStore.Patrones.FactoryMethod.Pagos;


public class PagoTransferencia : IPago
{
    public void Procesar(decimal total)
    {
        Console.WriteLine($"Procesando pago por transferencia bancaria por un monto de {total:C}");
    }
}