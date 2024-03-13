using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class SolicitudCredito
    {
        public double Monto { get; }

        public SolicitudCredito(double monto)
        {
            Monto = monto;
        }
    }

}
