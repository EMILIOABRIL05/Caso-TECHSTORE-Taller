namespace TechStore.Patrones.AbstractFactory.Ventas;

public class EmpaqueNormal : IEmpaque
{
    public void Empacar()
    {
         Console.WriteLine("Empaque NORMAL: caja estándar sin protección adicional.");
    }
}