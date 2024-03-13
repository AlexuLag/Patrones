using Bridge;

IPlataformaEnvio windowsEnvio = new WindowsEnvio();
IPlataformaEnvio linuxEnvio = new LinuxEnvio();

// Mensajes a enviar en diferentes plataformas
Mensaje correoWindows = new CorreoElectronico(windowsEnvio);
Mensaje correoLinux = new CorreoElectronico(linuxEnvio);
Mensaje smsWindows = new SMS(windowsEnvio);
Mensaje smsLinux = new SMS(linuxEnvio);

// Envío de mensajes
correoWindows.Enviar();
correoLinux.Enviar();
smsWindows.Enviar();
smsLinux.Enviar();