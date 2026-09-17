using TechStore.Core;

namespace TechStore.Patrones.Builder;

public class PaqueteEntregaBuilder
{
    private readonly PaqueteEntrega _paquete = new();

    public PaqueteEntregaBuilder ConTipoCaja(string tipoCaja)
    {
        _paquete.TipoCaja = tipoCaja;
        return this;
    }

    public PaqueteEntregaBuilder ConProteccion(string proteccion)
    {
        _paquete.Proteccion = proteccion;
        return this;
    }

    public PaqueteEntregaBuilder ConSeguro(bool seguro = true)
    {
        _paquete.Seguro = seguro;
        return this;
    }

    public PaqueteEntregaBuilder ConEtiquetaFragil(bool etiquetaFragil = true)
    {
        _paquete.EtiquetaFragil = etiquetaFragil;
        return this;
    }

    public PaqueteEntregaBuilder ConObservacion(string observacion)
    {
        _paquete.Observacion = observacion;
        return this;
    }

    public PaqueteEntrega Construir()
    {
        return _paquete;
    }
}