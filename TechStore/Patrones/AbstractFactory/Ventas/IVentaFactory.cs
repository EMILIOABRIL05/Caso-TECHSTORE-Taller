namespace TechStore.Patrones.AbstractFactory.Ventas;

public interface IVentaFactory
{
    IEmpaque CrearEmpaque();
    IEntrega CrearEntrega();
}