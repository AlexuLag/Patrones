using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class DecoradorCuenta : ICuentaBancaria
    {
        protected ICuentaBancaria cuenta;

        public DecoradorCuenta(ICuentaBancaria cuenta)
        {
            this.cuenta = cuenta;
        }

        public virtual void AbrirCuenta()
        {
            cuenta.AbrirCuenta();
        }
    }

}
