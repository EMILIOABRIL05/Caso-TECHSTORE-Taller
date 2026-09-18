namespace TechStore.Patrones.AbstractFactory.Ventas;

public class VentaNormalFactory : IVentaFactory
{
    public IEntrega CrearEntrega() => new EntregaNormal();
    public IEmpaque CrearEmpaque() => new EmpaqueNormal();
}