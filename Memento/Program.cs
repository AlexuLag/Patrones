using Memento;

Originator originator = new Originator();
Caretaker caretaker = new Caretaker();

// Cambiar y guardar el estado del originator
originator.Estado = "Estado 1";
caretaker.AgregarMemento(originator.CrearMemento());

// Cambiar y guardar otro estado del originator
originator.Estado = "Estado 2";
caretaker.AgregarMemento(originator.CrearMemento());

// Restaurar el primer estado
originator.RestaurarDesdeMemento(caretaker.ObtenerMemento(0));