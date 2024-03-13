using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class BicicletaMontaniaBuilder : IBicicletaBuilder
    {
        private Bicicleta bicicleta = new Bicicleta();

        public void ConstruirCuadro()
        {
            bicicleta.AgregarComponente("Cuadro de montaña resistente");
        }

        public void ConstruirManillares()
        {
            bicicleta.AgregarComponente("Manillares de montaña con buen agarre");
        }

        public void ConstruirNeumaticos()
        {
            bicicleta.AgregarComponente("Neumáticos de montaña gruesos y con tacos");
        }

        public void ConstruirSillin()
        {
            bicicleta.AgregarComponente("Sillín cómodo para recorridos largos");
        }

        public Bicicleta ObtenerBicicleta()
        {
            return bicicleta;
        }
    }

}
