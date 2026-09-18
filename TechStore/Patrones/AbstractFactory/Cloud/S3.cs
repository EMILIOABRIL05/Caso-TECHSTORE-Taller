namespace TechStore.Patrones.AbstractFactory.Cloud;

public class S3 : IStorage
{
    public void Guardar()
    {
        Console.WriteLine("AWS S3: archivo guardado correctamente en almacenamiento cloud.");
    }
}