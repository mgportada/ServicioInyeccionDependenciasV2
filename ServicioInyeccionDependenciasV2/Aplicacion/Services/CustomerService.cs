using ServicioInyeccionDependenciasV2.Dependencies;
using ServicioInyeccionDependenciasV2.Dominio;

namespace ServicioInyeccionDependenciasV2.Aplicacion.Services
{
    public class CustomerService : IRepository
    {
        private IRepository _service;

        public CustomerService(IRepository repository)
        {
            _service = repository;
        }

        public List<Customers> GetCustomers()
        {
            return _service.GetCustomers();
        }
    }
}
