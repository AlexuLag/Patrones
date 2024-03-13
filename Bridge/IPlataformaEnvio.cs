using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    interface IPlataformaEnvio
    {
        void EnviarMensaje(string mensaje);
    }
}
