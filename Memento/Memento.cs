using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Memento
    {
        public string Estado { get; private set; }

        public Memento(string estado)
        {
            Estado = estado;
        }
    }
}
