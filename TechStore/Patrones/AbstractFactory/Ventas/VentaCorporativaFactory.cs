namespace TechStore.Patrones.AbstractFactory.Ventas;

public class VentaCorporativaFactory : IVentaFactory
{
    public IEntrega CrearEntrega() => new EntregaProgramada();
    public IEmpaque CrearEmpaque() => new EmpaqueCorporativo();
}
