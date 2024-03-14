using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface IVisitante
    {
        void Visitar(Circulo circulo);
        void Visitar(Cuadrado cuadrado);
        void Visitar(Triangulo triangulo);
    }
}
