using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ChatMediator : IChatMediator
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public void EnviarMensaje(string mensaje, Usuario usuario)
        {
            foreach (var u in usuarios)
            {
                // Se excluye al usuario que envía el mensaje
                if (u != usuario)
                    u.RecibirMensaje(mensaje);
            }
        }
    }
}
