
using ServicioInyeccionDependenciasV2.Aplicacion.Dependencia;
using ServicioInyeccionDependenciasV2.Infraestructura.Senders;

namespace ServicioInyeccionDependenciasV2.Aplicacion.Services
{
    public class CommunicationService
    {
        private ISender _sender;
        public CommunicationService(ISender sender)
        {
            _sender = sender;
        }

        public void SendMessage(string email, string message)
        {
            _sender.SendMessage(email, message);
        }
    }
}
