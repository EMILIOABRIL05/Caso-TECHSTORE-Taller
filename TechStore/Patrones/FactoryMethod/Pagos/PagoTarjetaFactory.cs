namespace TechStore.Patrones.FactoryMethod.Pagos;

public class PagoTarjetaFactory : PagoFactory {
            
    public override IPago CrearPago() => new PagoTarjeta();
}