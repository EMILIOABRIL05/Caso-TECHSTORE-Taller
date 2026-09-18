using System;
namespace TechStore.Patrones.Singleton;

public sealed class Bitacora
{
    private static readonly Lazy<Bitacora> _instancia = new Lazy<Bitacora>(() => new Bitacora());
    private Bitacora(){
        Console.WriteLine("[SISTEMA] Instancia única de Bitácora inicializada.");
    }

    public static Bitacora Instancia => _instancia.Value;

    public void Registrar(string mensaje)
    {
        Console.WriteLine($"[LOG {DateTime.Now:HH:mm:ss}] {mensaje}");
    }

}