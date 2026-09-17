namespace TechStore.Patrones.FactoryMethod.Reportes;


public class ReporteExcelFactory : ReporteFactory
{
    
    public override IReporte GenerarReporte()
    {
        return new ReporteExcel();
        
    }
}