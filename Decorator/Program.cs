using Decorator;

ICuentaBancaria cuenta = new CuentaBancaria();

// Agregar funcionalidades adicionales utilizando Decorators
cuenta = new SeguroRobo(cuenta);
cuenta = new BonificacionIntereses(cuenta);

// Abrir la cuenta (se llamará a los métodos de los decoradores en cascada)
cuenta.AbrirCuenta();