using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Observador : IObservador
    {
        private string nombre;

        public Observador(string nombre)
        {
            this.nombre = nombre;
        }

        public void Actualizar(string mensaje)
        {
            Console.WriteLine($"[{nombre}] Recibí la notificación: {mensaje}");
        }
    }

}
