namespace TechStore.Patrones.AbstractFactory.Proveedores;

public class DellLaptop : ILaptop
{
    public void MostrarDetalle()
    {
        Console.WriteLine("DELL: Laptop Latitude 7440 con procesador Intel Core i7 y batería de larga duración.");
    }
}
