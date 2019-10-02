using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;
using MyHRManagement.Forms;
using MyHRManagement.UserControls;

namespace MyHRManagement.UserControls
{
    public partial class UpdateDesignation : UserControl
    {

        //Connectiong String Link here
        string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;


        //DataTable Gobal Variable 
        DataTable dtDesignation;

        //Select Row Gobal Variable
        int SelectRow;

        private static UpdateDesignation _updateDesignation;
        public static UpdateDesignation InstanceUpDes
        {
            get
            {
                if (_updateDesignation == null)
                    _updateDesignation = new UpdateDesignation();
                return _updateDesignation;
            }
        }
        public UpdateDesignation()
        {
            InitializeComponent();
        }

        private void UpdateDesignation_Load(object sender, EventArgs e)
        {
            GetDesignationList();
        }


        //Declare a method for load data on form run time event
        private DataTable GetDesignationList()
        {
            SqlConnection con = new SqlConnection(cs);

            con.Open();

            string showQry = "SELECT*FROM SGHR.HrDesignation";
            SqlCommand cmd = new SqlCommand(showQry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dtDesignation = new DataTable();
            da.Fill(dtDesignation);
            dGVUpdateDesignation.DataSource = dtDesignation.DefaultView;

            con.Close();

            return dtDesignation;
        }

        private void txtUpDesSearch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtDesignation);
            DV.RowFilter = string.Format("DegName LIKE '%{0}%'", txtUpDesSearch.Text);
            dGVUpdateDesignation.DataSource = DV;
        }

        private void btnUpdateDesignation_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                if (txtBoxID.Text != "" && txtBoxAddDesignation.Text != "")
                {
                    con.Open();
                    string qry = "UPDATE SGHR.HrDesignation SET DegName='" + txtBoxAddDesignation.Text + "'WHERE DegID ='" + txtBoxID.Text + "'";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@degname", txtBoxAddDesignation.Text);
                    cmd.Parameters.AddWithValue("@degid", txtBoxID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Data Successfullt!!!");


                    txtBoxID.Text = "";
                    txtBoxAddDesignation.Text = "";




                    string showQry = "SELECT*FROM SGHR.HrDesignation";
                    cmd = new SqlCommand(showQry, con);
                     dtDesignation = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtDesignation);
                    dGVUpdateDesignation.DataSource = dtDesignation.DefaultView;

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please Provide Designation Id And Name!!!!");
                }

            }
        }

        private void btnDeleteDesignation_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string qry = "DELETE FROM SGHR.HrDesignation WHERE DegID=@degid";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@degid", txtBoxID.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Data Successfully!!!");

                string showQry = "SELECT * FROM SGHR.HrDesignation";
                cmd = new SqlCommand(showQry, con);
                dtDesignation = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtDesignation);
                dGVUpdateDesignation.DataSource = dtDesignation.DefaultView;

                con.Close();

            }
        }


        //Show data on box from GridView Row Selected
        private void dGVUpdateDesignation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow = e.RowIndex;
            DataGridViewRow row = dGVUpdateDesignation.Rows[SelectRow];
            txtBoxID.Text = row.Cells[0].Value.ToString();
            txtBoxAddDesignation.Text = row.Cells[2].Value.ToString();
           
        }
    }
}
