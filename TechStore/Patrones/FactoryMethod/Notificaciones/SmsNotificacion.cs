namespace Patrones.FactoryMethod.Notificaciones{

public class SmsNotificacion : INotificacion
    {
  

        public void Enviar()
        {
            Console.WriteLine("Enviando SMS");
        }
    }
}