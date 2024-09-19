using Polimorfismo.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Clases
{
    public class EmpleadoAdministrativo : DocenteContratoFijo
    {
        //Hereda de DocenteContratoFijo porque los dos son empleados con contrato fijo
        public EmpleadoAdministrativo(string nombre, string apellido, string cedula, decimal salarioMensual, bool alcanzoMeta) 
            : base(nombre, apellido, cedula, salarioMensual, alcanzoMeta)
        {
        }

    }
}
