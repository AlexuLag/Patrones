using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Sujeto : ISujeto
    {
        private List<IObservador> observadores = new List<IObservador>();

        public void RegistrarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void QuitarObservador(IObservador observador)
        {
            observadores.Remove(observador);
        }

        public void NotificarObservadores(string mensaje)
        {
            foreach (var observador in observadores)
            {
                observador.Actualizar(mensaje);
            }
        }

        // Método para simular un evento que notifica a los observadores
        public void RealizarEvento(string mensaje)
        {
            Console.WriteLine($"Algo sucedió: {mensaje}");
            NotificarObservadores(mensaje);
        }
    }
}
