namespace TechStore.Patrones.AbstractFactory.Ventas;

public class EmpaqueCorporativo : IEmpaque
{
    public void Empacar()
    {
        Console.WriteLine("Empaque CORPORATIVO: caja institucional con protección reforzada y etiquetado corporativo.");
    }
}