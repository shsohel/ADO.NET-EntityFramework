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
    public partial class AddDepartment : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;

        DataTable dtDepart;
       


        private static AddDepartment _instancedp;
        public static AddDepartment InstanceDP
        {
            get
            {
                if (_instancedp == null)
                    _instancedp = new AddDepartment();
                return _instancedp;
            }
        }
        public AddDepartment()
        {
            InitializeComponent();
        }


        private void AddDepartment_Load(object sender, EventArgs e)
        {
            GetDespartList();
        }

        private DataTable GetDespartList()
        {
            SqlConnection con = new SqlConnection(cs);

            con.Open();

            string showQry = "SELECT*FROM SGHR.Departments";
            SqlCommand cmd = new SqlCommand(showQry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dtDepart = new DataTable();
            da.Fill(dtDepart);
            DGVDepartment.DataSource = dtDepart.DefaultView;

            con.Close();

            return dtDepart;
        }


        private void btnSubmitDepartment_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            if (txtBoxDepartName.Text != "" && txtBoxDepartType.Text != "" && txtBoxDepartDesc.Text != "")
            {
                con.Open();
                string qry = "sp_AllDepartments";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@deptid", SqlDbType.Int);
                cmd.Parameters.AddWithValue("@deptname", SqlDbType.VarChar).Value = txtBoxDepartName.Text;
                cmd.Parameters.AddWithValue("@deptype", SqlDbType.VarChar).Value = txtBoxDepartType.Text;
                cmd.Parameters.AddWithValue("@depdesc", SqlDbType.VarChar).Value = txtBoxDepartDesc.Text;
                cmd.Parameters.AddWithValue("@operation", SqlDbType.VarChar).Value = cmBoxOperation.Text;


                cmd.ExecuteNonQuery();
                MessageBox.Show("Record saved successfully!!!");

                txtBoxDepartName.Text = "";
                txtBoxDepartType.Text = "";
                txtBoxDepartDesc.Text = "";
                cmBoxOperation.Text = "";

                con.Close();

                //Data Load 
                con.Open();
                string showQry = "SELECT*FROM SGHR.Departments";
                cmd = new SqlCommand(showQry, con);
                dtDepart = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtDepart);
                DGVDepartment.DataSource = dtDepart.DefaultView;
                con.Close();

            }
            else
            {
                MessageBox.Show("Something Wrong Here");
            }
        }

        private void txtSearchDept_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtDepart);
            DV.RowFilter = string.Format("DeptName LIKE '%{0}%'", txtSearchDept.Text);
            DGVDepartment.DataSource = DV;
        }
    }
}
