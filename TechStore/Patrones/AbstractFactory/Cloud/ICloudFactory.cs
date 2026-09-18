namespace TechStore.Patrones.AbstractFactory.Cloud;

public interface ICloudFactory
{
    IStorage CrearStorage();
    IQueue CrearQueue();
}