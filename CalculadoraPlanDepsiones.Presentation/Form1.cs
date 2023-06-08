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

                PersonType personType = new PersonType(autonomo, empleado);
                Calculations calculator = new Calculations(personType, salary);

                decimal haciendaReturnedMoney = calculator.Calculate(inversion);
                MessageBox.Show($"Has invertido {inversion:0.##} como teniendo un sueldo anual de {salary:0.##}, por lo que hacienda te ha devuelto: {haciendaReturnedMoney:0.##}.");
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
                decimal haciendaReturnedMoney = service.CalculateDesgravacionInversion(autonomo, empleado, salary, inversion);
                
                if (haciendaReturnedMoney > 0)
                {
                    MessageBox.Show($"Has invertido {inversion:0.##} como teniendo un sueldo anual de {salary:0.##}, por lo que hacienda te ha devuelto: {haciendaReturnedMoney:0.##}.");
                }
                else
                {
                    MessageBox.Show($"WCF ha devuelto {haciendaReturnedMoney}, revisa que los valores sean correctos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
