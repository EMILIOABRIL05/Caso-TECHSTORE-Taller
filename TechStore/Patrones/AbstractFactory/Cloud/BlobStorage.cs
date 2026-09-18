namespace TechStore.Patrones.AbstractFactory.Cloud;

public class BlobStorage : IStorage
{
    public void Guardar()
    {
        Console.WriteLine("AZURE Blob Storage: archivo guardado correctamente en almacenamiento cloud.");
    }
}