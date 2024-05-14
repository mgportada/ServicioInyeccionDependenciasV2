using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServicioInyeccionDependenciasV2.Dominio;

namespace ServicioInyeccionDependenciasV2.Infraestructura.Repositories.Dependencias
{
    public interface IRepository
    {
        public List<Customers> GetCustomers();
    }
}