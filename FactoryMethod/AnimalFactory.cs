using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class AnimalFactory
    {
        public static Animal CrearAnimal<T>() where T : Animal, new()
        {
            return new T();
        }
    }
}
