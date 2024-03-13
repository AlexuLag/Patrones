using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class MueblesOficinaFactory : IMueblesFactory
    {
        public ISilla CrearSilla()
        {
            return new SillaOficina();
        }

        public IMesa CrearMesa()
        {
            return new MesaOficina();
        }
    }
}
