using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CrimeRecord
{
    public partial class ApplicationLogin : Form
    {
        public ApplicationLogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=New_CRMS;Integrated Security=True");


        private void bunifuGradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from AppLogin where UserName = '" + txtusername.Text + "' and UserPassword = '" + txtpassword.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                FirstDashBoard fd = new FirstDashBoard();
                fd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Enter the Valid UserName and Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //SqlCommand sqlcmd = new SqlCommand("USP_VALIDATEUSER", conn);

            //sqlcmd.CommandType = CommandType.StoredProcedure;

            //sqlcmd.Parameters.AddWithValue("@USERNAME", txtusername.Text);
            //sqlcmd.Parameters.AddWithValue("@PASSWORD", underline.Text);
            ////sqlcmd.Parameters.Add("@status", SqlDbType.VarChar, 200);
            ////sqlcmd.Parameters["@status"].Direction = ParameterDirection.Output;

            //conn.Open();

            //var res = sqlcmd.ExecuteNonQuery();
            ////String status = sqlcmd.Parameters["@status"].Value.ToString();

            
            //    this.Hide();
            //    FirstDashBoard f = new FirstDashBoard();
            //    f.ShowDialog();
           
            //conn.Close();
        }

        private void txtusername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtpassword1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Sorry Resetting password is Invalid");
        }

        private void Btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
