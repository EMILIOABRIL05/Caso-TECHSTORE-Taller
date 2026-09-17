using TechStore.Core;

namespace TechStore.Patrones.Builder;
public class ComputadoraBuilder
{
    private readonly Computadora _computadora = new Computadora();

    public ComputadoraBuilder ConProcesador(string procesador)
    {
        _computadora.Procesador = procesador;
        return this;
    }

    public ComputadoraBuilder ConRam(int ramGB)
    {
        _computadora.RamGB = ramGB;
        return this;
    }

    public ComputadoraBuilder ConDisco(int discoGB)
    {
        _computadora.DiscoGB = discoGB;
        return this;
    }

    public ComputadoraBuilder ConTarjetaGrafica(string tarjetaGrafica)
    {
        _computadora.TarjetaGrafica = tarjetaGrafica;
        return this;
    }

    public ComputadoraBuilder ConSistemaOperativo(string sistemaOperativo)
    {
        _computadora.SistemaOperativo = sistemaOperativo;
        return this;
    }

    public ComputadoraBuilder ConWifi(bool tiene = true)
    {
        _computadora.TieneWifi = tiene;
        return this;
    }

    public Computadora Construir()
    {
        return _computadora;
    }
}
