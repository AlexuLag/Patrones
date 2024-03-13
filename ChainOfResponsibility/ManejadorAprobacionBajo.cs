using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class ManejadorAprobacionBajo : ManejadorAprobacionBase
    {
        private double limite = 1000;

        public override void ManejarSolicitud(SolicitudCredito solicitud)
        {
            if (solicitud.Monto <= limite)
            {
                Console.WriteLine($"La solicitud de crédito por {solicitud.Monto} ha sido aprobada por el manejador de aprobación bajo.");
            }
            else
            {
                base.ManejarSolicitud(solicitud);
            }
        }
    }
}
