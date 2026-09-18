namespace TechStore.Patrones.AbstractFactory.Ventas;

public class EntregaExpress : IEntrega
{
    public void Entregar()
    {
       Console.WriteLine("Entrega EXPRESS: el pedido llegará en 24 horas.");
    }
}