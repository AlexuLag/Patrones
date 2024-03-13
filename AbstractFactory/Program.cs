// See https://aka.ms/new-console-template for more information

using AbstractFactory;

IMueblesFactory mueblesOficinaFactory = new MueblesOficinaFactory();
// Crear silla de oficina
ISilla sillaOficina = mueblesOficinaFactory.CrearSilla();
// Utilizar silla de oficina
sillaOficina.Usar();

// Crear mesa de oficina
IMesa mesaOficina = mueblesOficinaFactory.CrearMesa();
// Utilizar mesa de oficina
mesaOficina.Utilizar();

// Crear fábrica de muebles de hogar
IMueblesFactory mueblesHogarFactory = new MueblesHogarFactory();
// Crear silla de hogar
ISilla sillaHogar = mueblesHogarFactory.CrearSilla();
// Utilizar silla de hogar
sillaHogar.Usar();

// Crear mesa de hogar
IMesa mesaHogar = mueblesHogarFactory.CrearMesa();
// Utilizar mesa de hogar
mesaHogar.Utilizar();