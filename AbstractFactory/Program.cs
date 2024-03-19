// See https://aka.ms/new-console-template for more information

using AbstractFactory;




IMueblesFactory fabrica = MuebleFactory.CrearFabrica("Oficina");
ISilla silla =   fabrica.CrearSilla();
IMesa  mesa = fabrica.CrearMesa();
silla.Usar();
mesa.Utilizar();

 fabrica = MuebleFactory.CrearFabrica("Hogar");

 silla = fabrica.CrearSilla();
 mesa = fabrica.CrearMesa();
silla.Usar();
mesa.Utilizar();


