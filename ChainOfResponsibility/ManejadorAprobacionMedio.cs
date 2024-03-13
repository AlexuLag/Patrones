using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class ManejadorAprobacionMedio : ManejadorAprobacionBase
    {
        private double limite = 5000;

        public override void ManejarSolicitud(SolicitudCredito solicitud)
        {
            if (solicitud.Monto <= limite)
            {
                Console.WriteLine($"La solicitud de crédito por {solicitud.Monto} ha sido aprobada por el manejador de aprobación medio.");
            }
            else
            {
                base.ManejarSolicitud(solicitud);
            }
        }
    }

}
