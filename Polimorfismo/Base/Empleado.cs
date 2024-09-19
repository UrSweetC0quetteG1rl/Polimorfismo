using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Base
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }

        public Empleado(string nombre, string apellido, string cedula)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
        }

        public abstract decimal CalculoDeSalario();

        public override string ToString()
        {
            return string.Format($"\nNombre: {Nombre}\nApellido: {Apellido}\nCedula: {Cedula}");
        }
    }
}
