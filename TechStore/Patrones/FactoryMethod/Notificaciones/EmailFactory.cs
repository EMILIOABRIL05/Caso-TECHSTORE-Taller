using Patrones.FactoryMethod.Notificaciones;
namespace TechStore.Patrones.FactoryMethod.Notificaciones
{
    
    public class EmailFactory : NotificacionFactory
    {
        public override INotificacion CrearNotificacion()
        {
            return new EmailNotificacion();
        }
    }
}