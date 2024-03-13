using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class SeguroRobo : DecoradorCuenta
    {
        public SeguroRobo(ICuentaBancaria cuenta) : base(cuenta) { }

        public override void AbrirCuenta()
        {
            base.AbrirCuenta();
            Console.WriteLine("Seguro de robo agregado a la cuenta.");
        }
    }

}
