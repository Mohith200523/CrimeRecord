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
    public partial class FirRegistration : Form
    {
        public FirRegistration()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecondDashBoard sd = new SecondDashBoard();
            sd.ShowDialog();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecondDashBoard sd = new SecondDashBoard();
            sd.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
