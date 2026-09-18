namespace TechStore.Patrones.AbstractFactory.Ventas;

public class EmpaquePremium : IEmpaque
{
    public void Empacar()
    {
        Console.WriteLine("Empaque PREMIUM: caja reforzada con protección extra y sello de calidad.");
    }
}