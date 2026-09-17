
namespace TechStore.Patrones.FactoryMethod.Reportes;

public class ReporteExcel : IReporte
{
    
public void Reportar()
    {
Console.WriteLine("[EXCEL] Exportando pedido en formato de celdas (.xlsx) con fórmulas de cálculo de totales.");
    }
}