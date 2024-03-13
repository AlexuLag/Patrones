using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class CorreoElectronico : Mensaje
    {
        public CorreoElectronico(IPlataformaEnvio plataformaEnvio) : base(plataformaEnvio) { }

        public override void Enviar()
        {
            plataformaEnvio.EnviarMensaje("Correo electrónico");
        }
    }

}
