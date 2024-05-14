using ServicioInyeccionDependenciasV2.Dominio;

namespace ServicioInyeccionDependenciasV2.Dependencies;
public interface IRepository
{
    public List<Customers> GetCustomers();
}