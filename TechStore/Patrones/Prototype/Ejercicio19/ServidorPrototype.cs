namespace TechStore.Patrones.Prototype.Ejercicio19;

public class ServidorPrototype
{
    public string Nombre { get; set; } = string.Empty;
    public ConfiguracionRed ConfiguracionRed { get; set; } = new();

    public ServidorPrototype Clonar()
    {
        return new ServidorPrototype
        {
            Nombre = Nombre,
            ConfiguracionRed = new ConfiguracionRed
            {
                Ip = ConfiguracionRed.Ip,
                Puerto = ConfiguracionRed.Puerto
            }
        };
    }

    public override string ToString()
    {
        return $"[SERVIDOR PROTOTYPE]\n" +
               $"  Nombre:  {Nombre}\n" +
               $"  IP:      {ConfiguracionRed.Ip}\n" +
               $"  Puerto:  {ConfiguracionRed.Puerto}";
    }
}