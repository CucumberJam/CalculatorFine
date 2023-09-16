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
    public partial class frmResult : Form
    {
        public frmResult()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refCalculFineUsual_Click(object sender, EventArgs e)
        {
            new frmMainCalculator().Show();
            this.Hide();
        }

        private void refCalculFineCustom_Click(object sender, EventArgs e)
        {
            new frmCalculateForCustomer().Show();
            this.Hide();
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            txtDebt.Text = ResultCalculation.debt;
            txtPercent.Text = ResultCalculation.percent;
            txtDays.Text = ResultCalculation.days;
            txtTotalSum.Text =ResultCalculation.total;
        }
    }
}
