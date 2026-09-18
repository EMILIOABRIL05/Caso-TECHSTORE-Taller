namespace TechStore.Patrones.AbstractFactory.Ventas;

public class VentaPremiumFactory : IVentaFactory
{
    public IEntrega CrearEntrega() => new EntregaExpress();
    public IEmpaque CrearEmpaque() => new EmpaquePremium();
}

