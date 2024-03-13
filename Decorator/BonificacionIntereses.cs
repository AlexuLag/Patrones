using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class BonificacionIntereses : DecoradorCuenta
    {
        public BonificacionIntereses(ICuentaBancaria cuenta) : base(cuenta) { }

        public override void AbrirCuenta()
        {
            base.AbrirCuenta();
            Console.WriteLine("Bonificación de intereses agregada a la cuenta.");
        }
    }
}
