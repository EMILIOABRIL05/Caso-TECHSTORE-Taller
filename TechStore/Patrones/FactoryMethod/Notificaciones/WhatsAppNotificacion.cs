namespace Patrones.FactoryMethod.Notificaciones{

public class WhatsAppNotificacion : INotificacion
    {
  

        public void Enviar()
        {
            Console.WriteLine("Enviando mensaje de WhatsApp...");
        }
    }
}