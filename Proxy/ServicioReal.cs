using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class ServicioReal : IServicio
    {
        public void Request()
        {
            Console.WriteLine("Servicio real: Manejo de la petición.");
        }
    }
}
