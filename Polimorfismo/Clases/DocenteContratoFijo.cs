using Polimorfismo.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Clases
{
    public class DocenteContratoFijo : Empleado
    {
        private decimal _salarioMensual;
        private const decimal bonoBase = 5000;
        public bool AlcanzoMeta {  get; set; }

        public DocenteContratoFijo(string nombre, string apellido, string cedula, decimal salarioMensual, bool alcanzoMeta)
            : base(nombre, apellido, cedula)
        {
            SalarioMensual = salarioMensual;
            AlcanzoMeta = alcanzoMeta;
        }

        public decimal SalarioMensual
        {
            get { return _salarioMensual; }
            set { _salarioMensual = ((value > 0) ? value : 0); }
        }


        public override decimal CalculoDeSalario()
        {
            decimal bonificacion = AlcanzoMeta ? bonoBase : bonoBase / 2;
            return SalarioMensual + bonificacion;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nTipo de empleado: fijo \nSalario: {CalculoDeSalario()}";
        }
    }
}
