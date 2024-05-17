using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServicioInyeccionDependenciasV2.Aplicacion.Dependencia;
using ServicioInyeccionDependenciasV2.Aplicacion.Services;
using ServicioInyeccionDependenciasV2.Infraestructura.Repositories.Dependencias;
using ServicioInyeccionDependenciasV2.Infraestructura.Repositories;
using ServicioInyeccionDependenciasV2.Infraestructura.Senders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioInyeccionDependenciasV2.Aplicacion.Services.Tests
{
    [TestClass()]
    public class CustomerServiceTests
    {
        [TestMethod()]
        public void GetCustomersTest()
        {
            IDbConexion conexion = new Oracle();
            IRepository repository = new CustomerRepository(conexion);
            var customerService = new CustomerService(repository);
       

            var customers = customerService.GetCustomers();
            Assert.AreEqual(2, customers.Count());
        }
    }
}