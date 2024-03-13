﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class PajaroFactory : IAnimalFactory
    {
        public Animal CrearAnimal()
        {
            return new Pajaro();
        }
    }
}
