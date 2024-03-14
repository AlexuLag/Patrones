using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Originator
    {
        private string estado;

        public string Estado
        {
            get { return estado; }
            set
            {
                Console.WriteLine("Estado actualizado a: " + value);
                estado = value;
            }
        }

        // Método para crear un memento que guarda el estado actual
        public Memento CrearMemento()
        {
            return new Memento(estado);
        }

        // Método para restaurar el estado desde un memento
        public void RestaurarDesdeMemento(Memento memento)
        {
            estado = memento.Estado;
            Console.WriteLine("Estado restaurado a: " + estado);
        }
    }
}
