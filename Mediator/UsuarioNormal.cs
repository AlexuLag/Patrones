using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class UsuarioNormal : Usuario
    {
        public UsuarioNormal(IChatMediator chatMediator) : base(chatMediator)
        {
        }

        public override void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Usuario Normal envía mensaje: " + mensaje);
            chatMediator.EnviarMensaje(mensaje, this);
        }

        public override void RecibirMensaje(string mensaje)
        {
            Console.WriteLine("Usuario Normal recibe mensaje: " + mensaje);
        }
    }

}
