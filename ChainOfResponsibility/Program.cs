// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;
// Crear la cadena de manejadores
ManejadorAprobacionBase manejadorBajo = new ManejadorAprobacionBajo();
ManejadorAprobacionBase manejadorMedio = new ManejadorAprobacionMedio();
ManejadorAprobacionBase manejadorAlto = new ManejadorAprobacionAlto();

manejadorBajo.EstablecerSiguiente(manejadorMedio);
manejadorMedio.EstablecerSiguiente(manejadorAlto);

// Procesar solicitudes
ProcesarSolicitud(new SolicitudCredito(200), manejadorBajo);
ProcesarSolicitud(new SolicitudCredito(5000), manejadorBajo);
ProcesarSolicitud(new SolicitudCredito(15000), manejadorBajo);


static void ProcesarSolicitud(SolicitudCredito solicitud, ManejadorAprobacionBase manejador)
{
    Console.WriteLine($"Procesando solicitud de crédito por {solicitud.Monto}...");
    manejador.ManejarSolicitud(solicitud);
    Console.WriteLine();
}