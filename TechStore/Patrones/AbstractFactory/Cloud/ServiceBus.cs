namespace TechStore.Patrones.AbstractFactory.Cloud;

public class ServiceBus : IQueue
{
    public void Publicar()
    {
        Console.WriteLine("AZURE Service Bus: mensaje publicado correctamente en la cola.");
    }
}