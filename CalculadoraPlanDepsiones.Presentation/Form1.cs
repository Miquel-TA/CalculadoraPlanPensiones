using CalculadoraPlanPensiones.BusinessRules;
using System;
using System.Windows.Forms;

namespace CalculadoraPlanDepsiones.Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal inversion = Decimal.Parse(InversionText.Text);
                decimal salary = Decimal.Parse(SalarioText.Text);

                bool autonomo = AutonomoCheckbox.Checked;
                bool empleado = EmpleadoCheckbox.Checked;

                PersonType personType = new PersonType(autonomo, empleado, salary);
                Calculations calculator = new Calculations(personType);

                decimal haciendaReturnedMoney = calculator.Calculate(inversion);

                switch (haciendaReturnedMoney)
                {
                    case -1m:
                        MessageBox.Show($"Has superado tu límite de inversión correspondiente a tu tipo de persona.");
                        break;
                    case -2m:
                        MessageBox.Show($"El salario es incorrecto.");
                        break;
                    case -3m:
                        MessageBox.Show("Excepción en el cálculo, revisa los valores introducidos.");
                        break;
                    default:
                        MessageBox.Show($"Has invertido {inversion:0.##} como teniendo un sueldo anual de {salary:0.##}, por lo que hacienda te ha devuelto: {haciendaReturnedMoney:0.##}.");
                        break;
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calcularWCFbutton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal inversion = Decimal.Parse(InversionText.Text);
                decimal salary = Decimal.Parse(SalarioText.Text);

                bool autonomo = AutonomoCheckbox.Checked;
                bool empleado = EmpleadoCheckbox.Checked;

                WCFService.IService service = new WCFService.ServiceClient();

                // Inicializar PersonType enviando parámetros al constructor no es posible?
                // WCFService.PersonType personType = new WCFService.PersonType(autonomo, empleado, salary);
                WCFService.PersonType personType = new WCFService.PersonType
                {
                    Autonomo = autonomo,
                    Empleado = empleado,
                    Salary = salary
                };

                decimal haciendaReturnedMoney = service.CalculateDesgravacionInversion(personType, inversion);
                
                switch (haciendaReturnedMoney)
                {
                    case -1m:
                        MessageBox.Show($"Has superado tu límite de inversión correspondiente a tu tipo de persona.");
                        break;
                    case -2m:
                        MessageBox.Show($"El salario es incorrecto.");
                        break;
                    case -3m:
                        MessageBox.Show("Excepción en el cálculo, revisa los valores introducidos.");
                        break;
                    default:
                        MessageBox.Show($"Has invertido {inversion:0.##} como teniendo un sueldo anual de {salary:0.##}, por lo que hacienda te ha devuelto: {haciendaReturnedMoney:0.##}.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
