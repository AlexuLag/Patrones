using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    interface IChatMediator
    {
        void EnviarMensaje(string mensaje, Usuario usuario);
        void AgregarUsuario(Usuario usuario);
    }
}
