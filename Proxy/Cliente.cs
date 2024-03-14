using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Cliente
    {
        private IServicio servicio;

        public Cliente(IServicio servicio)
        {
            this.servicio = servicio;
        }

        public void EjecutarServicio()
        {
            // El cliente interactúa con el servicio a través del proxy
            servicio.Request();
        }
    }
}
