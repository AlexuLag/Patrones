using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class AnimalFactory
    {
        private  static IAnimalFactory CrearFabrica<T>() where T : IAnimalFactory, new()
        {
            return new T();
        }

        public static Animal CrearAnimalPorNombre(string nombre)
        {
            Animal animal;

            switch (nombre)
            {
                case "Perro":
                    animal = CrearFabrica<PerroFactory>().CrearAnimal();
                    break;
                case "Gato":
                    animal = CrearFabrica<GatoFactory>().CrearAnimal();
                    break;
                case "Pajaro":
                    animal = CrearFabrica<PajaroFactory>().CrearAnimal();
                    break;
                default:
                        throw  new NotImplementedException("el animal especificado no existe");
                    

            }

            return animal;


        }
    }
}
