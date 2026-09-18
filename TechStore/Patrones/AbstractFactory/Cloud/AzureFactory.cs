namespace TechStore.Patrones.AbstractFactory.Cloud;

public class AzureFactory : ICloudFactory
{
    public IStorage CrearStorage() => new BlobStorage();
    public IQueue CrearQueue() => new ServiceBus();
}