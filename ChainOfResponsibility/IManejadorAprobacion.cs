using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    interface IManejadorAprobacion
    {
        void ManejarSolicitud(SolicitudCredito solicitud);
    }
}
