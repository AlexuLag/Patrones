using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class WindowsEnvio : IPlataformaEnvio
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine($"Mensaje enviado por Windows: {mensaje}");
        }
    }

}
