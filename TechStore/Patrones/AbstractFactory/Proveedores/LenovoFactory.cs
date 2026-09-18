namespace TechStore.Patrones.AbstractFactory.Proveedores;

public class LenovoFactory : IProveedorFactory
{
    public ILaptop CrearLaptop() => new LenovoLaptop();
    public IMonitor CrearMonitor() => new LenovoMonitor();
}
