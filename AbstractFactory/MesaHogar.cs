﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class MesaHogar : IMesa
    {
        public void Utilizar()
        {
            Console.WriteLine("Usando la mesa de hogar.");
        }
    }

}
