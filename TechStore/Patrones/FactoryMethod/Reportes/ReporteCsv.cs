
namespace TechStore.Patrones.FactoryMethod.Reportes;

public class ReporteCsv : IReporte
{
    
public void Reportar()
    {
     Console.WriteLine("[CSV] Exportando datos del pedido en texto plano delimitado por comas: Cliente,Producto,Precio,Fecha.");

    }
}