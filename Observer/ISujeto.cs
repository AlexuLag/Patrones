using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface ISujeto
    {
        void RegistrarObservador(IObservador observador);
        void QuitarObservador(IObservador observador);
        void NotificarObservadores(string mensaje);
    }
}
