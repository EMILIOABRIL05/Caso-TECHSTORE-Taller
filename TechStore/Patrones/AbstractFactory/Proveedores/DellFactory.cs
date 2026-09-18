namespace TechStore.Patrones.AbstractFactory.Proveedores;

public class DellFactory : IProveedorFactory
{
    public ILaptop CrearLaptop() => new DellLaptop();
    public IMonitor CrearMonitor() => new DellMonitor();
}
