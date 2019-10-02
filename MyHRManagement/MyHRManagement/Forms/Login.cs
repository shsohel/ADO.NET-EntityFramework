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
using System.Configuration;
using MyHRManagement.Forms;



namespace MyHRManagement.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {

                SqlDataAdapter cmd = new SqlDataAdapter("SELECT*FROM SGHR.MyUser WHERE  UserName = '" + txtUser.Text + "' AND Password = '" + txtPassword.Text + "' AND IsActive = 1 ", con);
                DataTable dt = new DataTable();
                cmd.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    Home mainhome = new Home();
                    mainhome.Show();
                }
                else
                {
                    MessageBox.Show("UserName or PassWord INcorrect");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            txtUser.Text = "";
            txtPassword.Text = "";
        }
    }
}
