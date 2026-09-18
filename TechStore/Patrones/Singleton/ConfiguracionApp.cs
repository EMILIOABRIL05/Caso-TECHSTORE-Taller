namespace TechStore.Patrones.Singleton;

public sealed class ConfiguracionApp
{
    private static readonly Lazy<ConfiguracionApp> _instancia = new(() => new ConfiguracionApp());

    private ConfiguracionApp()
    {
    }

    public static ConfiguracionApp Instancia => _instancia.Value;

    public string NombreTienda { get; private set; } = string.Empty;
    public string Moneda { get; private set; } = string.Empty;
    public string Ambiente { get; private set; } = string.Empty;

    public void Configurar(string nombreTienda, string moneda, string ambiente)
    {
        if (string.IsNullOrWhiteSpace(NombreTienda))
            NombreTienda = nombreTienda;

        if (string.IsNullOrWhiteSpace(Moneda))
            Moneda = moneda;

        if (string.IsNullOrWhiteSpace(Ambiente))
            Ambiente = ambiente;
    }
}
