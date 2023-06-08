using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPlanDepsiones.Presentation
{
    internal class PlanDePensionesDTO
    {

        public decimal PPPersonaFisica { get; set; }
        public decimal PPEmpresa { get; set; }
        public decimal PPAutonomo { get; set; }

        public PlanDePensionesDTO(decimal pPPersonaFisica, decimal pPEmpresa, decimal pPAutonomo)
        {
            PPPersonaFisica = pPPersonaFisica;
            PPEmpresa = pPEmpresa;
            PPAutonomo = pPAutonomo;
        }

        public override bool Equals(object obj)
        {
            return obj is PlanDePensionesDTO dTO &&
                   PPPersonaFisica == dTO.PPPersonaFisica &&
                   PPEmpresa == dTO.PPEmpresa &&
                   PPAutonomo == dTO.PPAutonomo;
        }

        public override int GetHashCode()
        {
            int hashCode = 176752919;
            hashCode = hashCode * -1521134295 + PPPersonaFisica.GetHashCode();
            hashCode = hashCode * -1521134295 + PPEmpresa.GetHashCode();
            hashCode = hashCode * -1521134295 + PPAutonomo.GetHashCode();
            return hashCode;
        }
    }
}
