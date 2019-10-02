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

using System.IO;
using System.Drawing.Imaging;


namespace MyHRManagement.UserControls
{
    public partial class UpdateEmployee : UserControl
    {

        string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;

        //We can use gobal if We haven't same type selection.

        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dtDepart = new DataTable();

        string imageLocation = "";

        int active;

        int SelectRow;


        //Declare an Instance of  UpdateEmployee Control for Call it on it's button
        private static UpdateEmployee updateEmployee;
        public static UpdateEmployee InupdateEmployee
        {
            get
            {
                if (updateEmployee == null)
                    updateEmployee = new UpdateEmployee();
                return updateEmployee;
            }
        }



        public UpdateEmployee()
        {
            InitializeComponent();
            fillDepartCombo();
            fillDesCombo();
        }

        public void fillDepartCombo()
        {

            SqlConnection con = new SqlConnection(cs);
            string showQry = "SELECT DeptID, DeptName FROM SGHR.Departments";
            SqlCommand cmd = new SqlCommand(showQry, con);
            SqlDataAdapter dat = new SqlDataAdapter();
            DataTable dt = new DataTable();
            dat.SelectCommand = cmd;
            dat.Fill(dt);
            comboBoxDept.DataSource = dt;
            comboBoxDept.DisplayMember = "DeptName";
            comboBoxDept.ValueMember = "DeptID";

        }


        public void fillDesCombo()
        {
            SqlConnection con = new SqlConnection(cs);
            string showQry = "SELECT DegID, DegName FROM SGHR.HrDesignation";
            cmd = new SqlCommand(showQry, con);
            da.SelectCommand = cmd;
            da.Fill(dtDepart);
            comboBoxDes.DataSource = dtDepart;
            comboBoxDes.DisplayMember = "DegName";
            comboBoxDes.ValueMember = "DegID";
        }





        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            GetEmployeeList();
        }


        private DataTable GetEmployeeList()
        {
            SqlConnection con = new SqlConnection(cs);

            con.Open();

            string showQry = "SELECT*FROM SGHR.Employees";
            SqlCommand cmd = new SqlCommand(showQry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dtDepart = new DataTable();
            da.Fill(dtDepart);
            DGVEmployee.DataSource = dtDepart.DefaultView;
            con.Close();
            return dtDepart;
        }

        private void btnSubmitEmployee_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            if (checkboxYes.Checked || checkBoxNo.Checked)
            {
                con.Open();
                string qry = "sp_AllCRUDEmployee";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empid", SqlDbType.Int).Value=txtEmpID.Text;
                cmd.Parameters.AddWithValue("@empfirstname", SqlDbType.VarChar).Value = txtEmpFirstName.Text;
                cmd.Parameters.AddWithValue("@emplastname", SqlDbType.VarChar).Value = txtEmpLastName.Text;
                cmd.Parameters.AddWithValue("@gender", SqlDbType.VarChar).Value = comboBoxGender.Text;
                cmd.Parameters.AddWithValue("@maritalstatus", SqlDbType.VarChar).Value = comboBoxMarital.Text;
                cmd.Parameters.AddWithValue("@cellphone", SqlDbType.VarChar).Value = txtEmpPhone.Text;
                cmd.Parameters.AddWithValue("@dob", SqlDbType.Date).Value = Convert.ToDateTime(dtpDOB.Text);
                cmd.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = txtEmpEmail.Text;
                cmd.Parameters.AddWithValue("@bloodgroup", SqlDbType.VarChar).Value = txtEmpBloodGroup.Text;

                cmd.Parameters.AddWithValue("@address", SqlDbType.VarChar).Value = txtEmpAddress.Text;
                cmd.Parameters.AddWithValue("@joiningdate", SqlDbType.Date).Value = Convert.ToDateTime(dtpEmpJoinDate.Text);
                cmd.Parameters.AddWithValue("@terminationdate", SqlDbType.Date).Value = Convert.ToDateTime(dtpEmpTerDate.Text);


                byte[] images = null;
                FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                cmd.Parameters.AddWithValue("@emimage", images);

                cmd.Parameters.AddWithValue("@deptid", SqlDbType.Int).Value = comboBoxDept.SelectedValue.ToString();

                cmd.Parameters.AddWithValue("@designationid", SqlDbType.Int).Value = comboBoxDes.SelectedValue.ToString();

                cmd.Parameters.AddWithValue("@isactive", SqlDbType.Bit).Value = (Convert.ToInt32(active));


                cmd.Parameters.AddWithValue("@operation", SqlDbType.VarChar).Value = comboBoxOperation.Text;


                cmd.ExecuteNonQuery();
                MessageBox.Show("Record saved successfully!!!");

                txtEmpAddress.Text = "";

                txtEmpBloodGroup.Text = "";
                txtEmpEmail.Text = "";
                txtEmpFirstName.Text = "";
                txtEmpLastName.Text = "";
                txtEmpPhone.Text = "";
                comboBoxDept.Text = "";
                comboBoxDes.Text = "";
                comboBoxGender.Text = "";
                comboBoxMarital.Text = "";
                comboBoxOperation.Text = "";


                File.Copy(txtPicLocation.Text, Path.Combine(@"..\..\Pics", Path.GetFileName(txtPicLocation.Text)), true);

                con.Close();

                //Data Load 
                con.Open();
                string showQry = "SELECT*FROM SGHR.Employees";
                cmd = new SqlCommand(showQry, con);
                dtDepart = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtDepart);
                DGVEmployee.DataSource = dtDepart.DefaultView;
                con.Close();

            }
            else
            {
                MessageBox.Show("Something Wrong Here");
            }
        }

        private void DGVEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow = e.RowIndex;
            DataGridViewRow row = DGVEmployee.Rows[SelectRow];
            txtEmpID.Text = row.Cells[0].Value.ToString();
            txtEmpFirstName.Text = row.Cells[1].Value.ToString();
            txtEmpLastName.Text = row.Cells[2].Value.ToString();
            comboBoxGender.Text = row.Cells[3].Value.ToString();
            comboBoxMarital.Text = row.Cells[4].Value.ToString();
            txtEmpPhone.Text = row.Cells[5].Value.ToString();
            dtpDOB.Text = row.Cells[6].Value.ToString();
            txtEmpEmail.Text = row.Cells[7].Value.ToString();
            txtEmpBloodGroup.Text = row.Cells[8].Value.ToString();
            txtEmpAddress.Text = row.Cells[9].Value.ToString();
            dtpEmpJoinDate.Text = row.Cells[10].Value.ToString();
            dtpEmpTerDate.Text = row.Cells[11].Value.ToString();
          
            comboBoxDept.Text = row.Cells[13].Value.ToString();
            comboBoxDes.Text = row.Cells[14].Value.ToString();
            active.GetType();


        }

        private void checkboxYes_CheckedChanged(object sender, EventArgs e)
        {
            active = 1;
        }

        private void checkBoxNo_CheckedChanged(object sender, EventArgs e)
        {
            active = 2;
        }

        private void btnPicUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName.ToString();
                picEmployee.ImageLocation = imageLocation;

                txtPicLocation.Text = dialog.FileName;
                picEmployee.Image = new Bitmap(dialog.FileName);
            }
        }
    }
}
