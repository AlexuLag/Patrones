using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class VisitanteAreaPerimetro : IVisitante
    {
        public void Visitar(Circulo circulo)
        {
            double area = Math.PI * circulo.Radio * circulo.Radio;
            double perimetro = 2 * Math.PI * circulo.Radio;
            Console.WriteLine($"Círculo - Área: {area}, Perímetro: {perimetro}");
        }

        public void Visitar(Cuadrado cuadrado)
        {
            double area = cuadrado.Lado * cuadrado.Lado;
            double perimetro = 4 * cuadrado.Lado;
            Console.WriteLine($"Cuadrado - Área: {area}, Perímetro: {perimetro}");
        }

        public void Visitar(Triangulo triangulo)
        {
            double area = (Math.Sqrt(3) / 4) * triangulo.Lado * triangulo.Lado;
            double perimetro = 3 * triangulo.Lado;
            Console.WriteLine($"Triángulo - Área: {area}, Perímetro: {perimetro}");
        }
    }
}
