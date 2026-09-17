namespace TechStore.Patrones.FactoryMethod.Pagos;

public class PagoEfectivoFactory : PagoFactory {
            
    public override IPago CrearPago() => new PagoEfectivo();
}
