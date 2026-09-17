namespace TechStore.Patrones.FactoryMethod.Reportes;


public class ReportePdfFactory : ReporteFactory
{
    
    public override IReporte GenerarReporte()
    {
        return new ReportePdf();
        
    }
}