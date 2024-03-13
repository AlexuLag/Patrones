using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SillaHogar : ISilla
    {
        public void Usar()
        {
            Console.WriteLine("Usando la silla de hogar.");
        }
    }
}
