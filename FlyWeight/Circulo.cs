using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Circulo : IObjetoGrafico
    {
        private string color;

        public Circulo(string color)
        {
            this.color = color;
        }

        public void Dibujar(int x, int y)
        {
            Console.WriteLine($"Dibujando un círculo de color {color} en ({x}, {y})");
        }
    }
}
