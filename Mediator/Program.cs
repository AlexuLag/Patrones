using Mediator;

IChatMediator chat = new ChatMediator();

UsuarioNormal usuario1 = new UsuarioNormal(chat);
UsuarioNormal usuario2 = new UsuarioNormal(chat);
UsuarioNormal usuario3 = new UsuarioNormal(chat);

chat.AgregarUsuario(usuario1);
chat.AgregarUsuario(usuario2);
chat.AgregarUsuario(usuario3);

usuario1.EnviarMensaje("Hola a todos!");
usuario2.EnviarMensaje("¿Cómo están?");