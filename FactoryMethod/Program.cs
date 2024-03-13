// See https://aka.ms/new-console-template for more information
// Uso del Factory Method con diferentes tipos de animales
using FactoryMethod;

IAnimalFactory perroFactory = new PerroFactory();
IAnimalFactory gatoFactory = new GatoFactory();
IAnimalFactory pajaroFactory = new PajaroFactory();

Animal miPerro = perroFactory.CrearAnimal();
Animal miGato = gatoFactory.CrearAnimal();
Animal miPajaro = pajaroFactory.CrearAnimal();

Console.WriteLine(miPerro.HacerSonido());  // Salida: Woof!
Console.WriteLine(miGato.HacerSonido());   // Salida: Meow!
Console.WriteLine(miPajaro.HacerSonido());  // Salida: Tweet!
