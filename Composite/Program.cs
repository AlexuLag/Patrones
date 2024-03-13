using Composite;

IEmpleado gerente = new Empleado("Ana", "Gerente de Proyecto");
IEmpleado empleado1 = new Empleado("Juan", "Desarrollador");
IEmpleado empleado2 = new Empleado("Maria", "Diseñadora");
IEmpleado empleado3 = new Empleado("Pedro", "Jefe de qa");
IEmpleado empleado4 = new Empleado("john", "tester ");
IEmpleado empleado5 = new Empleado("alexander", "tester ");
IEmpleado empleado6 = new Empleado("jimenez", "tester ");

// Crear gerente y agregar empleados como subordinados

gerente.AgregarSubordinado(empleado1);
gerente.AgregarSubordinado(empleado2);
gerente.AgregarSubordinado(empleado3);
empleado3.AgregarSubordinado(empleado4);
empleado3.AgregarSubordinado(empleado5);
empleado3.AgregarSubordinado(empleado6);

// Mostrar detalles del gerente y sus subordinados
Console.WriteLine(gerente.ObtenerDetalles());