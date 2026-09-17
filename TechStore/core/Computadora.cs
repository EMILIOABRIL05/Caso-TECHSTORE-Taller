namespace TechStore.Core
{
    public class Computadora
    {
        public string Procesador { get; set; } = string.Empty;
        public int RamGB { get; set; }
        public int DiscoGB { get; set; }
        public string TarjetaGrafica { get; set; } = string.Empty;
        public string SistemaOperativo { get; set; } = string.Empty;
        public bool TieneWifi { get; set; }

        public override string ToString()
        {
            return $"[COMPUTADORA]\n" +
                   $"  Procesador:        {Procesador}\n" +
                   $"  RAM:               {RamGB}GB\n" +
                   $"  Disco:             {DiscoGB}GB\n" +
                   $"  Tarjeta Gráfica:   {TarjetaGrafica}\n" +
                   $"  Sistema Operativo: {SistemaOperativo}\n" +
                   $"  Wi-Fi:             {(TieneWifi ? "Sí" : "No")}";
        }
    }
}
