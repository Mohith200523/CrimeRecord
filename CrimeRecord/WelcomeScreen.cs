using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimeRecord
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
            //timer1_Tick();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                //timer1.Start();
                xuiFlatProgressBar1.Value += 1;
                if (xuiFlatProgressBar1.Value >= 100)
                {
                    timer1.Stop();
                    ApplicationLogin frm = new ApplicationLogin();
                    frm.Show();
                    this.Hide();
                }

            }
            catch (Exception)
            {
                return;
            }
        }

        private void xuiFlatProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
