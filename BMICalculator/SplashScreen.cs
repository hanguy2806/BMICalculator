using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Enabled = false;
            Program.splashScreen.Hide();

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.Width = 320;
            this.Height = 480;
            splashTimer.Enabled = true;
            progressBar.Value += 1;
            Program.bmiForm.Show();
        }
    }
}
