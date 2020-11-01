using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimeRecord
{
    public partial class FirstDashBoard : Form
    {
        public FirstDashBoard()
        {
            InitializeComponent();
            backgroundPicture.BringToFront();
            backgroundPicture.Show();
            petgridview.Hide();
            VictimGridView.Hide();
            OfficerGridView.Hide();
            FIRGridView.Hide();
            ComplainGridView.Hide();
        }
        
        private void bunifuGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin sd = new AdminLogin();
            sd.ShowDialog();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        public void PetDataLoad()
        {
            String Sql = "Select * from Table_Petitioner";
            petgridview.DataSource = DBConnection.GetTableByQuery(Sql);
        }

        private void btnpetitioner_Click(object sender, EventArgs e)
        {
            PetDataLoad();
            petgridview.Show();
            petgridview.BringToFront();
            backgroundPicture.Hide();
            VictimGridView.Hide();
            OfficerGridView.Hide();
            FIRGridView.Hide();
            ComplainGridView.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicationLogin al = new ApplicationLogin();
            al.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            backgroundPicture.Show();
            backgroundPicture.BringToFront();
            petgridview.Hide();
            VictimGridView.Hide();
            OfficerGridView.Hide();
            FIRGridView.Hide();
            ComplainGridView.Hide();
        }

        public void ComplainDataLoad()
        {
            String Sql = "Select * from Table_Complain";
            ComplainGridView.DataSource = DBConnection.GetTableByQuery(Sql);
        }

        public void VictimDataLoad()
        {
            String Sql = "Select * from Table_Victim";
            VictimGridView.DataSource = DBConnection.GetTableByQuery(Sql);
        }

        public void OfficerDataLoad()
        {
            String Sql = "Select * from Table_InvestigationOfficer";
            OfficerGridView.DataSource = DBConnection.GetTableByQuery(Sql);
        }

        public void FIRDataLoad()
        {
            String Sql = "Select * from Table_FIR";
            FIRGridView.DataSource = DBConnection.GetTableByQuery(Sql);
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            ComplainDataLoad();
            ComplainGridView.Show();
            ComplainGridView.BringToFront();
            petgridview.Hide();
            backgroundPicture.Hide();
            VictimGridView.Hide();
            OfficerGridView.Hide();
            FIRGridView.Hide();
        }

        private void btnvictim_Click(object sender, EventArgs e)
        {
            VictimDataLoad();
            VictimGridView.Show();
            VictimGridView.BringToFront();
            petgridview.Hide();
            OfficerGridView.Hide();
            ComplainGridView.Hide();
            FIRGridView.Hide();
            backgroundPicture.Hide();
        }

        private void btnofficer_Click(object sender, EventArgs e)
        {
            OfficerDataLoad();
            OfficerGridView.Show();
            backgroundPicture.Hide();
            petgridview.Hide();
            VictimGridView.Hide();
            FIRGridView.Hide();
            ComplainGridView.Hide();
        }

        private void btnfir_Click(object sender, EventArgs e)
        {
            FIRDataLoad();
            FIRGridView.Show();
            backgroundPicture.Hide();
            petgridview.Hide();
            VictimGridView.Hide();
            OfficerGridView.Hide();
            ComplainGridView.Hide();
        }
    }
}
