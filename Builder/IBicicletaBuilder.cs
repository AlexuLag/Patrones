using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface IBicicletaBuilder
    {
        void ConstruirCuadro();
        void ConstruirManillares();
        void ConstruirNeumaticos();
        void ConstruirSillin();
        Bicicleta ObtenerBicicleta();
    }
}
