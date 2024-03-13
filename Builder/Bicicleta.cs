using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Bicicleta
    {
        private List<string> componentes = new List<string>();

        public void AgregarComponente(string componente)
        {
            componentes.Add(componente);
        }

        public void Mostrar()
        {
            Console.WriteLine("Bicicleta construida con los siguientes componentes:");
            foreach (var componente in componentes)
            {
                Console.WriteLine(componente);
            }
        }
    }
}
