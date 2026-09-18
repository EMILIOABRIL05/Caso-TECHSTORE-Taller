namespace TechStore.Patrones.AbstractFactory.Proveedores;

public class LenovoLaptop : ILaptop
{
    public void MostrarDetalle()
    {
        Console.WriteLine("LENOVO: Laptop ThinkPad X1 con teclado ergonómico y excelente durabilidad.");
    }
}
