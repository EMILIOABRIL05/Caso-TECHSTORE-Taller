namespace TechStore.Core;

public class PaqueteEntrega
{
    public string TipoCaja { get; set; } = string.Empty;
    public string Proteccion { get; set; } = string.Empty;
    public bool Seguro { get; set; }
    public bool EtiquetaFragil { get; set; }
    public string Observacion { get; set; } = string.Empty;


    public override string ToString()
    {
   return $"[PAQUETE DE ENTREGA]\n" +
                   $"  Tipo de Caja:    {TipoCaja}\n" +
                   $"  Protección:      {Proteccion}\n" +
                   $"  Seguro:          {(Seguro ? "Sí" : "No")}\n" +
                   $"  Etiqueta Frágil: {(EtiquetaFragil ? "Sí" : "No")}\n" +
                   $"  Observación:     {(string.IsNullOrWhiteSpace(Observacion) ? "Ninguna" : Observacion)}";
        }
   



}