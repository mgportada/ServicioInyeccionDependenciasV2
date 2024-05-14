using System.Data;
using ServicioInyeccionDependenciasV2.Aplicacion.Dependencia;
using ServicioInyeccionDependenciasV2.Dominio;
using ServicioInyeccionDependenciasV2.Infraestructura.Repositories.Dependencias;

namespace ServicioInyeccionDependenciasV2.Infraestructura.Repositories
{
    public class CustomerRepository:IRepository
    {
        private IDbConexion _connection;

        public CustomerRepository(IDbConexion dbConnection)
        {
            _connection = dbConnection;
        }

        public List<Customers> GetCustomers()
        {
            if (_connection.GetType() == typeof(MySQLConnection))
            {
                Console.WriteLine("Connection is MySQL");
            }
            if (_connection.GetType() == typeof(Oracle))
            {
                Console.WriteLine("Connection is Oracle");
            }

            return new List<Customers>
                {
                    new Customers { ID = 1, Name = "John Doe", Email = "jonh@gmail.com", Phone="1234567890"},
                    new Customers { ID = 2, Name = "Jane Doe", Email = "jane@gmail.com", Phone="0987654321"}
                };
        }
    }
}
