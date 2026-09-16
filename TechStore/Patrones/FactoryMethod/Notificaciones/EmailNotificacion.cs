namespace Patrones.FactoryMethod.Notificaciones{

public class EmailNotificacion : INotificacion
    {
  

        public void Enviar()
        {
            Console.WriteLine("Enviando correo");
        }
    }
}