namespace TechStore.Patrones.AbstractFactory.Ventas;

public class EntregaProgramada : IEntrega
{
    public void Entregar()
    {
        Console.WriteLine("Entrega PROGRAMADA: el pedido se entrega en fecha y horario coordinado con la empresa.");
    }
}
