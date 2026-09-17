namespace TechStore.Patrones.FactoryMethod.Reportes;

public class ReportePdf : IReporte
{
    public void Reportar()
    {
        Console.WriteLine("[PDF] Generando documento de pedido maquetado con encabezados y diseño listo para imprimir.");
    }
}