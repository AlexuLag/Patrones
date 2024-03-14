using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class FabricaObjetosGraficos
    {
        private Dictionary<string, IObjetoGrafico> objetosGraficos = new Dictionary<string, IObjetoGrafico>();

        public IObjetoGrafico ObtenerObjetoGrafico(string color)
        {
            if (!objetosGraficos.ContainsKey(color))
            {
                objetosGraficos[color] = new Circulo(color);
            }
            return objetosGraficos[color];
        }
    }

}
