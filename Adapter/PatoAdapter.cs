using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PatoAdapter : IPato
    {
        private IAve ave;

        public PatoAdapter(IAve ave)
        {
            this.ave = ave;
        }

        public void Volar()
        {
            ave.Volar();
        }

        public void Nadar()
        {
            Console.WriteLine("El pato está nadando...");
        }
    }
}
