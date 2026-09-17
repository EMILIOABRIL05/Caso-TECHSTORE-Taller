
namespace TechStore.Patrones.FactoryMethod.Notificaciones;

public class SmsFactory : NotificacionFactory
{
    public override INotificacion CrearNotificacion()
    {
        return new SmsNotificacion();
    }
}