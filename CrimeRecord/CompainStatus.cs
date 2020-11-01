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
    public partial class CompainStatus : Form
    {
        public CompainStatus()
        {
            InitializeComponent();
        }
       
        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void dataload()
        {
            String Sql = "Select * from Table_Complain";
            complaingridview.DataSource = DBConnection.GetTableByQuery(Sql);
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string query = "Delete from Table_Complain where Complain_ID = '" + txtcomplainid.Text + "'";
            complaingridview.DataSource = DBConnection.GetTableByQuery(query);
            MessageBox.Show("Complaint Deleted Successfully");
            dataload();
        }

        private void bunifuGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String query = "update Table_Complain set Complain_Date='" + txtcomplaindate.Text + "',Section_of_Law='" + txtsectionoflaw.Text + "',Complain_Status='" + txtcomplainstatus.Text + "',Complain_Details='" + txtcomplaindetails.Text + "',Victim_Name='" + txtvictimname.Text + "',Accused_Name='" + txtaccusedname.Text + "' where Complain_ID='" + txtcomplainid.Text + "' ";
            complaingridview.DataSource = DBConnection.GetTableByQuery(query);
            MessageBox.Show("Data Updated Successfully");
            dataload();
            btnsave.Enabled = true;
        }

        private void txtsectionoflaw_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcomplaindate_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btnsave.Enabled = true;
            txtcomplaindate.Text = "";
            txtsectionoflaw.Text = "";
            txtcomplainstatus.Text = "";
            txtcomplaindetails.Text = "";
            txtvictimname.Text = "";
            txtaccusedname.Text = "";
            dataload();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            String Sql = "Insert into Table_Complain(Complain_Date, Section_of_Law, Complain_Status, Complain_Details, Victim_Name, Accused_Name) " +
                "values('" + txtcomplaindate.Text + "', '" + txtsectionoflaw.Text + "', '" + txtcomplainstatus.Text + "', '" + txtcomplaindetails.Text + "', '" + txtvictimname.Text + "', '" + txtaccusedname.Text + "')".ToString();
            complaingridview.DataSource = DBConnection.GetTableByQuery(Sql);
            dataload();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcomplaindetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcomplainstatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void complaingridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //get
            String cid = complaingridview.Rows[e.RowIndex].Cells[0].Value.ToString();
            String date = complaingridview.Rows[e.RowIndex].Cells[1].Value.ToString();
            String sec = complaingridview.Rows[e.RowIndex].Cells[2].Value.ToString();
            String status = complaingridview.Rows[e.RowIndex].Cells[3].Value.ToString();
            String details = complaingridview.Rows[e.RowIndex].Cells[4].Value.ToString();
            String vname = complaingridview.Rows[e.RowIndex].Cells[5].Value.ToString();
            String aname = complaingridview.Rows[e.RowIndex].Cells[6].Value.ToString();
            //set
            txtcomplainid.Text = cid;
            txtcomplaindate.Text = date;
            txtsectionoflaw.Text = sec;
            txtcomplainstatus.Text = status;
            txtcomplaindetails.Text = details;
            txtvictimname.Text = vname;
            txtaccusedname.Text = aname;
            btnsave.Enabled = false;
            btnview.Enabled = false;
        }

        private void bunifuGradientPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            dataload();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecondDashBoard sd = new SecondDashBoard();
            sd.ShowDialog();
        }
    }
}