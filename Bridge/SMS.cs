using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class SMS : Mensaje
    {
        public SMS(IPlataformaEnvio plataformaEnvio) : base(plataformaEnvio) { }

        public override void Enviar()
        {
            plataformaEnvio.EnviarMensaje("SMS");
        }
    }
}
