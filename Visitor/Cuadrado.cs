using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Cuadrado : IForma
    {
        public double Lado { get; set; }

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public void Aceptar(IVisitante visitante)
        {
            visitante.Visitar(this);
        }
    }
}
