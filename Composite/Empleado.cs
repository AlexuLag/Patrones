using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Empleado : IEmpleado
    {
        private string nombre;
        private string cargo;
        private List<IEmpleado> subordinados = new List<IEmpleado>();

        public Empleado(string nombre, string cargo)
        {
            this.nombre = nombre;
            this.cargo = cargo;
        }

        public void AgregarSubordinado(IEmpleado empleado)
        {
            subordinados.Add(empleado);
        }

        public void QuitarSubordinado(IEmpleado empleado)
        {
            subordinados.Remove(empleado);
        }

        public string ObtenerDetalles()
        {
            string detalles = $"{nombre}, {cargo}\nSubordinados:\n";
            foreach (var subordinado in subordinados)
            {
                detalles += $"- {subordinado.ObtenerDetalles()}\n";
            }
            return detalles;
        }
    }
}
