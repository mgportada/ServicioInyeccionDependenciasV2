using ServicioInyeccionDependenciasV2.Dependencies;
namespace ServicioInyeccionDependenciasV2.Infraestructura.Senders
{
    public class SMSService : ISender
    {
        public void SendMessage(string sms, string message) => Console.WriteLine("SMS sent to: " + sms + " with message: " + message);
    }
}