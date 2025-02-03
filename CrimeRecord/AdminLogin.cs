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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=New_CRMS;Integrated Security=True");

        private void checkBox_CheckedChanged(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Sorry Resetting password is Invalid");
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Table_Admin_LogIn where User_Name = '" + txtusername.Text + "' and Password = '" + txtpassword.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                SecondDashBoard fd = new SecondDashBoard();
                fd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Enter the Valid details", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstDashBoard fd = new FirstDashBoard();
            fd.ShowDialog();
        }
    }
}
