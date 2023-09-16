using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFine
{
    public partial class frmCalculateForCustomer : Form
    {
        public frmCalculateForCustomer()
        {
            InitializeComponent();
        }

        private void frmCalculateForCustomer_Load(object sender, EventArgs e)
        {
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal currentDebt = ConvertToDecimal(txtDebt.Text);

            DateTime firstDate = txtDateFirst.Value;
            DateTime currentTime = txtDateLast.Value;

            if (currentDebt < 0)
            {
                MessageBox.Show("Поле 'Сумма долга'  не может быть пустым",
                    "Calculation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (firstDate > currentTime)
            {
                MessageBox.Show($"Поле 'Дата подачи претензии': {txtDateFirst.Text} не может быть больше поля 'Дата окончания расчета неустойки:': {txtDateLast.Text}",
            "Calculation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal percent;
                if (btnFineHalfPercent.Checked)
                {
                    percent = 0.5m;
                }
                else if (btnFineOnePercent.Checked)
                {
                    percent = 1.0m;
                }
                else percent = 3.0m;

                Calculator calculatorFine = new Calculator(currentDebt, firstDate, currentTime, percent);
                decimal result = calculatorFine.CalculateFine();
                if (result == 0)
                {
                    MessageBox.Show(" Количество дней не может быть меньше 10 (срок ответа Исполнителем на претензию)",
            "Calculation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == -1)
                {
                    MessageBox.Show(" Количество дней не может быть больше 3 лет (1180 дней) - истечение срока исковой давности",
            "Calculation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ResultCalculation.debt = txtDebt.Text;
                ResultCalculation.percent = Convert.ToString(percent);
                ResultCalculation.days = calculatorFine.GetDays();
                ResultCalculation.total = Convert.ToString(Math.Round(result, 2));

                txtDebt.Text = "";
                txtDateFirst.Text = "";
                txtDateLast.Text = "";
                btnFineHalfPercent.Checked = true;

                new frmSplashScreen().Show();
                this.Hide();
            }
        }
        private decimal ConvertToDecimal(string str)
        {
            string[] arrayDebt = str.Split(' ');
            string current;
            if (arrayDebt.Length == 1)
            {
                current = arrayDebt[0].Remove(0, 1);
            }
            else current = arrayDebt[arrayDebt.Length - 1];
            current = current.Trim();
            decimal currentDebt;

            if (decimal.TryParse(current, out currentDebt))
            {
                return currentDebt;
            }
            else return -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDebt.Text = "";
            txtDateFirst.Text = "";
            txtDateLast.Text = "";
            btnFineHalfPercent.Checked = true;
            txtDebt.Focus();
        }

        private void refCalculFineUsual_Click(object sender, EventArgs e)
        {
            new frmMainCalculator().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
