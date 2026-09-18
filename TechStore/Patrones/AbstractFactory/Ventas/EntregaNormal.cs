namespace TechStore.Patrones.AbstractFactory.Ventas;

public class EntregaNormal : IEntrega
{
    public void Entregar()
    {
        Console.WriteLine("Entrega NORMAL: el pedido llegará en 5 a 7 días hábiles.");
    }
}