using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioInyeccionDependenciasV2.Aplicacion.Dependencies
{
    public interface ISender
    {
        public void SendMessage(string email, string message);
    }
}
