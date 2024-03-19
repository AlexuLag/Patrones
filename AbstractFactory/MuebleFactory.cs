using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class MuebleFactory
    {

        public static IMueblesFactory CrearFabrica(string nombreFabrica)
        {
            IMueblesFactory fabrica;


            switch (nombreFabrica) { 
                case "Oficina": 
                    fabrica = new MueblesOficinaFactory();
                    break;
                case "Hogar":
                    fabrica = new MueblesHogarFactory();
                    break;
                default:
                    throw new NotImplementedException("La fabrica no existe");

            }
            return fabrica;


        }
    }
}
