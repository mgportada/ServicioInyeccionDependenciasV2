using ServicioInyeccionDependenciasV2.Aplicacion.Services;
using ServicioInyeccionDependenciasV2.Dependencies;
using ServicioInyeccionDependenciasV2.Infraestructura.Repositories;
using ServicioInyeccionDependenciasV2.Infraestructura.Senders;

namespace ServicioInyeccionDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection sql = new MySQLConnection();
            var repo = new CustomerRepository(sql);
            var customerService = new CustomerService(repo);
            var smsService = new SMSService();
            var communicationService = new CommunicationService(smsService);

            var customers = customerService.GetCustomers();
            var message = "¡Hola! Su pedido ya está disponible para recoger. Gracias por usar nuestro servicio de mensajería";
            foreach (var customer in customers)
            {
                communicationService.SendMessage(customer.Phone, message);
            }
        }
    }
}