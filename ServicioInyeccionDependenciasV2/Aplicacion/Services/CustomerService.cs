using ServicioInyeccionDependenciasV2.Aplicacion.Dependencies;
using ServicioInyeccionDependenciasV2.Dominio;
using ServicioInyeccionDependenciasV2.Infraestructura.Repositories;

namespace ServicioInyeccionDependenciasV2.Aplicacion.Services
{
    public class CustomerService
    {
        private IRepository _repository;

        public CustomerService(IRepository repository)
        {
            _repository = repository;
        }

        public List<Customers> GetCustomers()
        {
            return _repository.GetCustomers();
        }
    }
}
