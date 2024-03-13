using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class CuentaBancaria : ICuentaBancaria
    {
        public void AbrirCuenta()
        {
            Console.WriteLine("Cuenta bancaria abierta.");
        }
    }
}
