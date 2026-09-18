namespace TechStore.Patrones.AbstractFactory.Cloud;

public class AwsFactory : ICloudFactory
{
    public IStorage CrearStorage() => new S3();
    public IQueue CrearQueue() => new Sqs();
}