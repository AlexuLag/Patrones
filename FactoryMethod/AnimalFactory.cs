using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class AnimalFactory
    {
        private  static Animal CrearAnimal<T>() where T : Animal, new()
        {
            return new T();
        }

        public static Animal CrearAnimalPorNombre(string nombre)
        {
            Animal animal;
            switch (nombre)
            {
                case "Perro":  
                    animal =  CrearAnimal<Perro>();
                    break;

                case "Gato":
                    animal =  CrearAnimal<Gato>();
                    break;
                case "Pajaro":
                    animal = CrearAnimal<Pajaro>();
                    break;
                default:
                        throw  new NotImplementedException("el animal especificado no existe");
                    

            }

            return animal;


        }
    }
}
