using ServicioInyeccionDependenciasV2.Dependencies;
namespace ServicioInyeccionDependenciasV2.Infraestructura.Senders
{
    public class EmailService : ISender
    {
        public void SendMessage(string email, string message)
        {
            Console.WriteLine("Email sent to: " + email + " with message: " + message);
        }
    }
}
