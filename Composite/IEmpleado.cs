using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    interface IEmpleado
    {
        string ObtenerDetalles();
        void AgregarSubordinado(IEmpleado empleado);
    }
}
