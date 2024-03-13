using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class ManejadorAprobacionBase : IManejadorAprobacion
    {
        private IManejadorAprobacion siguiente;

        public void EstablecerSiguiente(ManejadorAprobacionBase siguiente)
        {
            this.siguiente = siguiente;
        }

        public virtual void ManejarSolicitud(SolicitudCredito solicitud)
        {
            if (siguiente != null)
            {
                siguiente.ManejarSolicitud(solicitud);
            }
            else
            {
                Console.WriteLine("Solicitud no aprobada.");
            }
        }
    }

}
