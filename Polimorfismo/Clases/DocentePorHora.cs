using Polimorfismo.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Clases
{
    public class DocentePorHora : Empleado
    {
        private int _horasTrabajadas;
        public int HorasTrabajadas
        {
            get => _horasTrabajadas;
            set{ _horasTrabajadas = (value > 0) ? value : 0;}
        }
        private decimal PagoPorHora = 800;
        public DocentePorHora(string nombre, string apellido, string cedula, int horasTrabajadas) 
            : base(nombre, apellido, cedula)
        {
            HorasTrabajadas = horasTrabajadas;
        }

        public override decimal CalculoDeSalario()
        {
            return HorasTrabajadas * PagoPorHora;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nTipo de empledo: por hora \nSueldo: {CalculoDeSalario()}";
        }
    }
}
