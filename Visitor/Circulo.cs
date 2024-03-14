using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Circulo : IForma
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public void Aceptar(IVisitante visitante)
        {
            visitante.Visitar(this);
        }
    }
}
