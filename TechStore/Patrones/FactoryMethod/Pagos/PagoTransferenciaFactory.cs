namespace TechStore.Patrones.FactoryMethod.Pagos;


public class PagoTransferenciaFactory : PagoFactory {
            
    public override IPago CrearPago() => new PagoTransferencia();
}