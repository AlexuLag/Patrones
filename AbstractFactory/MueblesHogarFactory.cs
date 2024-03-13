using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class MueblesHogarFactory : IMueblesFactory
    {
        public ISilla CrearSilla()
        {
            return new SillaHogar();
        }

        public IMesa CrearMesa()
        {
            return new MesaHogar();
        }
    }
}
