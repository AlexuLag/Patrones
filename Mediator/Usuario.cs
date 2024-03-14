using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    abstract class Usuario
    {
        protected IChatMediator chatMediator;

        public Usuario(IChatMediator chatMediator)
        {
            this.chatMediator = chatMediator;
        }

        public abstract void EnviarMensaje(string mensaje);
        public abstract void RecibirMensaje(string mensaje);
    }
}
