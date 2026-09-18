namespace TechStore.Patrones.AbstractFactory.Proveedores;

public class LenovoMonitor : IMonitor
{
    public void MostrarDetalle()
    {
        Console.WriteLine("LENOVO: Monitor ThinkVision 24\" con brillo uniforme y diseño minimalista.");
    }
}
