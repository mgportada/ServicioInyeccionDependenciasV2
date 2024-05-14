using ServicioInyeccionDependenciasV2.Aplicacion.Dependencies;
using ServicioInyeccionDependenciasV2.Aplicacion.Services;
using ServicioInyeccionDependenciasV2.Infraestructura.Repositories;
using ServicioInyeccionDependenciasV2.Infraestructura.Senders;

namespace ServicioInyeccionDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection connection = new MySQLConnection();
            IRepository repository = new CustomerRepository(connection);
            var customerService = new CustomerService(repository);
            ISender smsService = new SMSService();

            var communicationService = new CommunicationService(smsService);

            var customers = customerService.GetCustomers();
            var message = "¡Hola! Su pedido ya está disponible para recoger. Gracias por usar nuestro servicio de mensajería";
            foreach (var customer in customers)
            {
                communicationService.SendMessage(customer.Email, message);
            }
        }
    }
}