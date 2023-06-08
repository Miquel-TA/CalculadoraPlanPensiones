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

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
                
            result.Append("Persona Fisica, ");

            if (this.Autonomo)
            {
                result.Append("Autonomo, ");
            }

            if (this.Empleado)
            {
                result.Append("Empleado, ");
            }

            return result.ToString();
        }
    }
}
