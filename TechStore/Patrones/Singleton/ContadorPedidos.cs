namespace TechStore.Patrones.Singleton;

public sealed class ContadorPedidos
{
    private static readonly Lazy<ContadorPedidos> _instancia = new(() => new ContadorPedidos());

    private ContadorPedidos()
    {
    }

    public static ContadorPedidos Instancia => _instancia.Value;

    public int Total { get; private set; }

    public void Incrementar()
    {
        Total++;
    }
}
