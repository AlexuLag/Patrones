using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Pajaro : IAve
    {
        public void Volar()
        {
            Console.WriteLine("El pájaro está volando...");
        }
    }
}
