namespace TechStore.Patrones.AbstractFactory.Proveedores;

public class DellMonitor : IMonitor
{
    public void MostrarDetalle()
    {
        Console.WriteLine("DELL: Monitor UltraSharp 27\" con resolución 4K y excelente color.");
    }
}
