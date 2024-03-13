using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class GatoFactory : IAnimalFactory
    {
        public Animal CrearAnimal()
        {
            return new Gato();
        }
    }
}
