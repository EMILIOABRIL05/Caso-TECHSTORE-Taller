

using TechStore.Patrones.FactoryMethod.Notificaciones;
namespace Patrones.FactoryMethod.Notificaciones
{
public class WhatsAppFactory : NotificacionFactory
{
    public override INotificacion CrearNotificacion()
    {
        return new WhatsAppNotificacion();
    }

}
}