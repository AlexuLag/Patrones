using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Mensaje
    {
        protected IPlataformaEnvio plataformaEnvio;

        public Mensaje(IPlataformaEnvio plataformaEnvio)
        {
            this.plataformaEnvio = plataformaEnvio;
        }

        public abstract void Enviar();
    }
}
