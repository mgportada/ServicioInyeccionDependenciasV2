using ServicioInyeccionDependenciasV2.Aplicacion.Dependencia;
using ServicioInyeccionDependenciasV2.Aplicacion.Services;
using ServicioInyeccionDependenciasV2.Infraestructura.Repositories;
using ServicioInyeccionDependenciasV2.Infraestructura.Repositories.Dependencias;
using ServicioInyeccionDependenciasV2.Infraestructura.Senders;

namespace ServicioInyeccionDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConexion conexion = new Oracle();
            IRepository repository = new CustomerRepository(conexion);
            var customerService = new CustomerService(repository);
            ISender emailServices = new SMSService();
            var communicationService = new CommunicationService(emailServices);

            var customers = customerService.GetCustomers();
            var message = "¡Hola! Su pedido ya está disponible para recoger. Gracias por usar nuestro servicio de mensajería";
            foreach (var customer in customers)
            {
                communicationService.SendMessage(customer.Email, message);
            }
        }
    }
}