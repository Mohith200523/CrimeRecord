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
    public partial class SecondDashBoard : Form
    {
        public SecondDashBoard()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnpet_Click(object sender, EventArgs e)
        {
            this.Hide();
            PetitionerDetails pd = new PetitionerDetails();
            pd.ShowDialog();
        }

        private void btncomplain_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompainStatus cs = new CompainStatus();
            cs.ShowDialog();
        }

        private void bunifuCards5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnaccused_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccusedRecord ar = new AccusedRecord();
            ar.ShowDialog();
        }

        private void btnvictim_Click(object sender, EventArgs e)
        {
            this.Hide();
            VictimDetails vd = new VictimDetails();
            vd.ShowDialog();
        }

        private void btofficer_Click(object sender, EventArgs e)
        {
            this.Hide();
            OfficerDetails od = new OfficerDetails();
            od.ShowDialog();
        }

        private void btnfir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirRegistration fr = new FirRegistration();
            fr.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstDashBoard fd = new FirstDashBoard();
            fd.ShowDialog();
        }
    }
}
