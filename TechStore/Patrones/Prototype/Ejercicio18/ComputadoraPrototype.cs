namespace TechStore.Patrones.Prototype.Ejercicio18;

public class ComputadoraPrototype
{
    public string NombreEquipo { get; set; } = string.Empty;
    public int MemoriaRam { get; set; }
    public string Procesador { get; set; } = string.Empty;
    public int DiscoGB { get; set; }
    public string TarjetaGrafica { get; set; } = string.Empty;
    public string SistemaOperativo { get; set; } = string.Empty;
    public bool TieneWifi { get; set; }

    public ComputadoraPrototype Clonar()
    {
        return new ComputadoraPrototype
        {
            NombreEquipo = NombreEquipo,
            MemoriaRam = MemoriaRam,
            Procesador = Procesador,
            DiscoGB = DiscoGB,
            TarjetaGrafica = TarjetaGrafica,
            SistemaOperativo = SistemaOperativo,
            TieneWifi = TieneWifi
        };
    }

    public override string ToString()
    {
        return $"[COMPUTADORA PROTOTYPE]\n" +
               $"  Nombre del equipo: {NombreEquipo}\n" +
               $"  Memoria RAM:      {MemoriaRam}GB\n" +
               $"  Procesador:       {Procesador}\n" +
               $"  Disco:            {DiscoGB}GB\n" +
               $"  Tarjeta gráfica:  {TarjetaGrafica}\n" +
               $"  Sistema operativo:{SistemaOperativo}\n" +
               $"  Wi-Fi:            {(TieneWifi ? "Sí" : "No")}";
    }
}