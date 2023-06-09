using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPlanPensiones.BusinessRules
{
    public class PersonType
    {
        public bool Autonomo { get; set; }
        public bool Empleado { get; set; }
        public decimal Salary { get; set; }

        public PersonType(bool autonomo, bool empleado, decimal Salary)
        {
            this.Autonomo = autonomo;
            this.Empleado = empleado;
            this.Salary = Salary;
        }
    }
}
