using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraPlanPensiones.BusinessRules
{
    //TODO Se deben crear tests para probar todas las posibilidades
    public class Calculations
    {
        private PersonType PersonType;
        private decimal TaxPercent;

        public Calculations(PersonType personType, decimal anualSalary)
        {
            PersonType = personType;
            TaxPercent = GetBracket(anualSalary);
        }

        public decimal Calculate(decimal investmentInPlanDePensiones)
        {
            decimal maxInvestment = 1500;
            if (PersonType.Autonomo) maxInvestment += 4250;
            if (PersonType.Empleado) maxInvestment += 8500;

            if (investmentInPlanDePensiones > maxInvestment)
            {
                throw new Exception($"La inversión es demasiado grande para tu tipo de persona. El límite es {maxInvestment}.");
            }

            decimal investmentReturned = investmentInPlanDePensiones * TaxPercent;

            return investmentReturned;
        }

        private decimal GetBracket(decimal salary)
        {
            List<(decimal Limit, decimal Rate)> taxBrackets = new List<(decimal Limit, decimal Rate)>()
            {
                (300000m, 0.47m),
                (60000m, 0.45m),
                (35200m, 0.37m),
                (20200m, 0.30m),
                (12451m, 0.24m),
                (0m, 0.19m)
            };
            foreach ((decimal Limit, decimal Rate) bracket in taxBrackets)
            {
                if (salary > bracket.Limit)
                {
                    return bracket.Rate;
                }
            }
            throw new Exception("Salario incorrecto.");
        }

    }
}
