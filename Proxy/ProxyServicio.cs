using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class ProxyServicio : IServicio
    {
        private ServicioReal servicioReal;

        public void Request()
        {
            // Se crea la instancia del servicio real solo cuando sea necesario
            if (servicioReal == null)
            {
                servicioReal = new ServicioReal();
            }

            // Se delega la solicitud al servicio real
            servicioReal.Request();
        }
    }
}
