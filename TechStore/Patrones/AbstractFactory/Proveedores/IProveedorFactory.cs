namespace TechStore.Patrones.AbstractFactory.Proveedores;

public interface IProveedorFactory
{
    ILaptop CrearLaptop();
    IMonitor CrearMonitor();
}
