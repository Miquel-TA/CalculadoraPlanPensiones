using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPlanPensiones.BusinessRules
{
    public class PersonType
    {
        public bool Autonomo { get; }
        public bool Empleado { get; }

        public PersonType(bool autonomo, bool empleado)
        {
            this.Autonomo = autonomo;
            this.Empleado = empleado;
        }
    }
}
