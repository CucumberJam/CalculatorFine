using System.Windows.Forms;
using System;

namespace CalculatorFine
{
    public partial class frmMainCalculator : Form
    {

        public frmMainCalculator()
        {
            InitializeComponent();

        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            decimal currentDebt = ConvertToDecimal(txtDebt.Text);
            DateTime firstDate = txtDateFirst.Value;
            DateTime currentTime = txtDateLast.Value;

            if (currentDebt < 0)
            {
                MessageBox.Show("���� '����� �����'  �� ����� ���� ������",
                    "Calculation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (firstDate > currentTime)
            {
                MessageBox.Show($"���� '���� ������ ���������': {txtDateFirst.Text} �� ����� ���� ������ ���� '���� ��������� ������� ���������:': {txtDateLast.Text}",
            "Calculation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPercent.Value == 0)
            {
                MessageBox.Show($"���� '������ ���������': {txtPercent.Value} �� ����� ���� ������",
            "Calculation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal percent = txtPercent.Value;
                int beforeFinePeriod = txtBeforeFinePeriod.Value != 10.0m ? (int)txtBeforeFinePeriod.Value : 10;
                bool withoutHolidays = btnWithoutHolidays.Checked ? true : false;
                bool withoutHolidaysClaimPeriod = btnWithoutHolidaysClaimPeriod.Checked ? true : false;
                bool annual = btnAnnual.Checked ? true : false;


                Calculator calculatorFine = new Calculator(currentDebt, firstDate, currentTime, percent, withoutHolidays, beforeFinePeriod, withoutHolidaysClaimPeriod, annual);
                decimal result = calculatorFine.CalculateFine();
                if (result == -2)
                {
                    MessageBox.Show(" ���������� ���� �� ����� ���� ������ 10 (���� ������ ������������ �� ���������)",
            "Calculation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == -1)
                {
                    MessageBox.Show(" ���������� ���� �� ����� ���� ������ 3 ��� (1180 ����) - ��������� ����� ������� ��������",
            "Calculation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ResultCalculation.debt = txtDebt.Text;
                ResultCalculation.percent = Convert.ToString(percent);
                ResultCalculation.days = calculatorFine.GetDays();
                ResultCalculation.total = Convert.ToString(Math.Round(result, 2));

                txtDebt.Text = "";
                txtPercent.Value = 0;
                btnWithHolidaysClaimPeriod.Checked = true;
                txtBeforeFinePeriod.Value = 10;
                btnEveryDay.Checked = true;
                btnWithHolidays.Checked = true;
                txtDateFirst.Text = "";
                txtDateLast.Text = "";

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDebt.Text = "";
            txtPercent.Value = 0;
            btnWithHolidaysClaimPeriod.Checked = true;
            txtBeforeFinePeriod.Value = 10;
            btnEveryDay.Checked = true;
            btnWithHolidays.Checked = true;
            txtDateFirst.Text = "";
            txtDateLast.Text = "";
            txtDebt.Focus();
        }

        private void refCalculFineCustomer_Click(object sender, EventArgs e)
        {
            new frmCalculateForCustomer().Show();
            this.Hide();
        }

    }
}