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
    public partial class UpdateDepartment : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;

        DataTable dtDepart;
        int SelectRow;

        private static UpdateDepartment _updateDep;
        public static UpdateDepartment InstanceUDP
        {
            get
            {
                if (_updateDep == null)
                    _updateDep = new UpdateDepartment();
                return _updateDep;
            }
        }
        public UpdateDepartment()
        {
            InitializeComponent();
        }

        private void UpdateDepartment_Load(object sender, EventArgs e)
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
            DGVUpDepartment.DataSource = dtDepart.DefaultView;

            con.Close();

            return dtDepart;
        }


        private void txtSearchDept_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtDepart);
            DV.RowFilter = string.Format("DeptName LIKE '%{0}%'", txtSearchDept.Text);
            DGVUpDepartment.DataSource = DV;
        }

        private void btnUpSubmitDepartment_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            if (txtBoxUpDepartName.Text != "" && txtBoxUpDepartType.Text != "" && txtBoxUpDepartDesc.Text != "" && cmBoxUpOperation.Text!="" || txtBoxUpDepartID.Text != "")
            {
                con.Open();
                string qry = "sp_AllDepartments";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@deptid", SqlDbType.Int).Value = txtBoxUpDepartID.Text;
                cmd.Parameters.AddWithValue("@deptname", SqlDbType.VarChar).Value = txtBoxUpDepartName.Text;
                cmd.Parameters.AddWithValue("@deptype", SqlDbType.VarChar).Value = txtBoxUpDepartType.Text;
                cmd.Parameters.AddWithValue("@depdesc", SqlDbType.VarChar).Value = txtBoxUpDepartDesc.Text;
                cmd.Parameters.AddWithValue("@operation", SqlDbType.VarChar).Value = cmBoxUpOperation.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record saved successfully!!!");



                txtBoxUpDepartDesc.Text = "";
                txtBoxUpDepartID.Text = "";
                txtBoxUpDepartName.Text = "";
                txtBoxUpDepartType.Text = "";
                cmBoxUpOperation.Text = "";
                con.Close();

                

                //Data Load 
                con.Open();
                string showQry = "SELECT*FROM SGHR.Departments";
                cmd = new SqlCommand(showQry, con);
                dtDepart = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtDepart);
                DGVUpDepartment.DataSource = dtDepart.DefaultView;

                con.Close();

            }

            else
            {
                MessageBox.Show("Something Wrong Here");
            }
        }

        private void DGVUpDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow = e.RowIndex;
            DataGridViewRow row = DGVUpDepartment.Rows[SelectRow];
            txtBoxUpDepartID.Text = row.Cells[0].Value.ToString();
            txtBoxUpDepartName.Text = row.Cells[1].Value.ToString();
            txtBoxUpDepartType.Text = row.Cells[2].Value.ToString();
            txtBoxUpDepartDesc.Text = row.Cells[3].Value.ToString();
        }
    }
}
