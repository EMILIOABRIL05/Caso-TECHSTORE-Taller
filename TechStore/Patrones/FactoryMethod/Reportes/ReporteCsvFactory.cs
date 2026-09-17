namespace TechStore.Patrones.FactoryMethod.Reportes;


public class ReporteCsvFactory : ReporteFactory
{
    
    public override IReporte GenerarReporte()
    {
        return new ReporteCsv();
        
    }
}