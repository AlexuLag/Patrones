using Observer;

Sujeto sujeto = new Sujeto();

// Crear observadores
Observador observador1 = new Observador("Observador 1");
Observador observador2 = new Observador("Observador 2");

// Registrar observadores con el sujeto
sujeto.RegistrarObservador(observador1);
sujeto.RegistrarObservador(observador2);

// Simular un evento que notifica a los observadores
sujeto.RealizarEvento("Evento A");

// Quitar un observador y simular otro evento
sujeto.QuitarObservador(observador1);
sujeto.RealizarEvento("Evento B");