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
    public partial class OfficerDetails : Form
    {
        public OfficerDetails()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecondDashBoard sd = new SecondDashBoard();
            sd.ShowDialog();
        }

        public void dataLoad()
        {
            String sql = "Select * from Table_InvestigationOfficer";
            Officergridview.DataSource = DBConnection.GetTableByQuery(sql);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecondDashBoard sd = new SecondDashBoard();
            sd.ShowDialog();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btnsave.Enabled = true;
            txtofficerid.Text = "";
            txtfullname.Text = "";
            txtrank.Text = "";
            dataLoad();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            dataLoad();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            String Sql = "Insert into Table_InvestigationOfficer(Full_Name, Rank) " +
                "values('" + txtfullname.Text + "', '" + txtrank.Text + "')".ToString();
            Officergridview.DataSource = DBConnection.GetTableByQuery(Sql);
            dataLoad();
        }

        private void Officergridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            //get
            String oid = Officergridview.Rows[e.RowIndex].Cells[0].Value.ToString();
            String name = Officergridview.Rows[e.RowIndex].Cells[1].Value.ToString();
            String rank = Officergridview.Rows[e.RowIndex].Cells[2].Value.ToString();
            //set
            txtofficerid.Text = oid;
            txtfullname.Text = name;
            txtrank.Text = rank;
            btnsave.Enabled = false;
            btnview.Enabled = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String query = "update Table_InvestigationOfficer set Full_Name='" + txtfullname.Text + "',Rank='" + txtrank.Text + "' where Officer_ID='" + txtofficerid.Text + "' ";
            Officergridview.DataSource = DBConnection.GetTableByQuery(query);
            MessageBox.Show("Data Updated Successfully");
            dataLoad();
            btnsave.Enabled = true;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string query = "Delete from Table_InvestigationOfficer where Officer_ID = '" + txtofficerid.Text + "'";
            Officergridview.DataSource = DBConnection.GetTableByQuery(query);
            MessageBox.Show("Officer Record Deleted Successfully");
            dataLoad();
        }
    }
}
