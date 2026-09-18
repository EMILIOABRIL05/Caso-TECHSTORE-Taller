namespace TechStore.Patrones.AbstractFactory.Ventas;

public class VentaNormalFactory : IVentaFactory
{
    public IEntrega CrearEntrega() => new EntregaExpress();
    public IEmpaque CrearEmpaque() => new EmpaqueNormal();
}