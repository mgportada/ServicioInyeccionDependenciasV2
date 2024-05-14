
using ServicioInyeccionDependenciasV2.Aplicacion.Dependencia;

namespace ServicioInyeccionDependenciasV2.Infraestructura.Senders
{
    public class SMSService:ISender
    {
        public void SendMessage(string email, string message)
        {
            Console.WriteLine("SMS sent to: " + email + " with message: " + message);
        }
    }
}
