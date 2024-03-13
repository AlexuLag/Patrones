using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Pajaro : Animal
    {
        public override string HacerSonido()
        {
            return "Tweet!";
        }
    }
}
