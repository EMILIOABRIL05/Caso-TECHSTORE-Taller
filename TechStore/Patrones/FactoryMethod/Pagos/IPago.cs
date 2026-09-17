namespace TechStore.Patrones.FactoryMethod.Pagos;

public interface IPago
{
    void Procesar(decimal total);
}