// See https://aka.ms/new-console-template for more information
using Builder;

IBicicletaBuilder montañaBuilder = new BicicletaMontaniaBuilder();
// Crear un director y pasarle el builder de montaña
DirectorBicicleta director = new DirectorBicicleta(montañaBuilder);
// Construir la bicicleta de montaña
director.ConstruirBicicleta();
// Obtener la bicicleta construida
Bicicleta bicicletaMontaña = montañaBuilder.ObtenerBicicleta();
// Mostrar los componentes de la bicicleta de montaña
bicicletaMontaña.Mostrar();
