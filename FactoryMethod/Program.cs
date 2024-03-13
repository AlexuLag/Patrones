// See https://aka.ms/new-console-template for more information
// Uso del Factory Method con diferentes tipos de animales
using FactoryMethod;

Animal miPerro = AnimalFactory.CrearAnimalPorNombre("Perro");
Animal miGato = AnimalFactory.CrearAnimalPorNombre("Gato");
Animal miPajaro = AnimalFactory.CrearAnimalPorNombre("Pajaro");

Console.WriteLine(miPerro.HacerSonido());  
Console.WriteLine(miGato.HacerSonido());   
Console.WriteLine(miPajaro.HacerSonido());  
