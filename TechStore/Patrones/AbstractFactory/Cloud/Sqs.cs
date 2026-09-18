namespace TechStore.Patrones.AbstractFactory.Cloud;

public class Sqs : IQueue
{
    public void Publicar()
    {
        Console.WriteLine("AWS SQS: mensaje publicado correctamente en la cola.");
    }
}