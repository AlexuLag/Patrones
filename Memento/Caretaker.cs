using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Caretaker
    {
        private List<Memento> mementos = new List<Memento>();

        public void AgregarMemento(Memento memento)
        {
            mementos.Add(memento);
        }

        public Memento ObtenerMemento(int indice)
        {
            return mementos[indice];
        }
    }

}
