using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class DirectorBicicleta
    {
        private IBicicletaBuilder builder;

        public DirectorBicicleta(IBicicletaBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstruirBicicleta()
        {
            builder.ConstruirCuadro();
            builder.ConstruirManillares();
            builder.ConstruirNeumaticos();
            builder.ConstruirSillin();
        }
    }
}
