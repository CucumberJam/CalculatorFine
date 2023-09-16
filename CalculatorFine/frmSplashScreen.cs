using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CircularProgressBar;

namespace CalculatorFine
{
    public partial class frmSplashScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public frmSplashScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            progressBar.Value = 0;
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value + 6 > 100)
            {
                timer1.Enabled = false;
                new frmResult().Show();
                this.Hide();
            }
            else
            {
                progressBar.Value += 6;
                progressPercent.Text = progressBar.Value.ToString() + " %";
            }
        }
    }
}
