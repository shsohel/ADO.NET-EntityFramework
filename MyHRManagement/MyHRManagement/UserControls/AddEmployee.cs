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
    public partial class AddEmployee : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;

        //We can use gobal if We haven't same type selection.

        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dtDepart = new DataTable();
        
        string imageLocation = "";

        int active;


        //Declare an Instance of AddEmployee Control for Call it on it's button
        private static AddEmployee addEmployee;
        public static AddEmployee InAddEmployee
        {
            get
            {
                if (addEmployee == null)
                    addEmployee = new AddEmployee();
                return addEmployee;
            }
        }

        public AddEmployee()
        {
            InitializeComponent();
            fillDepartCombo();
            fillDesCombo();
            
        }

        private void AddEmployee_Load(object sender, EventArgs e)
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

       

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            if (checkboxYes.Checked || checkBoxNo.Checked)
            {
                con.Open();
                string qry = "sp_AllCRUDEmployee";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empid", SqlDbType.Int);
                cmd.Parameters.AddWithValue("@empfirstname", SqlDbType.VarChar).Value = txtEmpFirstName.Text;
                cmd.Parameters.AddWithValue("@emplastname", SqlDbType.VarChar).Value = txtEmpLastName.Text;
                cmd.Parameters.AddWithValue("@gender", SqlDbType.VarChar).Value = comboBoxGender.Text;
                cmd.Parameters.AddWithValue("@maritalstatus", SqlDbType.VarChar).Value = comboBoxMarital.Text;
                cmd.Parameters.AddWithValue("@cellphone", SqlDbType.VarChar).Value = txtEmpPhone.Text;
                cmd.Parameters.AddWithValue("@dob", SqlDbType.Date).Value = Convert.ToDateTime( dtpDOB.Text);
                cmd.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value =  txtEmpEmail.Text;
                cmd.Parameters.AddWithValue("@bloodgroup", SqlDbType.VarChar).Value = txtEmpBloodGroup.Text;

                cmd.Parameters.AddWithValue("@address", SqlDbType.VarChar).Value = txtEmpAddress.Text;
                cmd.Parameters.AddWithValue("@joiningdate", SqlDbType.Date).Value = Convert.ToDateTime( dtpEmpJoinDate.Text);
                cmd.Parameters.AddWithValue("@terminationdate", SqlDbType.Date).Value = Convert.ToDateTime( dtpEmpTerDate.Text);

                               
                byte[] images = null;
                FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                cmd.Parameters.AddWithValue("@emimage", images);

                cmd.Parameters.AddWithValue("@deptid", SqlDbType.Int).Value = comboBoxDept.SelectedValue.ToString();
              
                cmd.Parameters.AddWithValue("@designationid", SqlDbType.Int).Value = comboBoxDes.SelectedValue.ToString();

                cmd.Parameters.AddWithValue("@isactive", SqlDbType.Bit).Value= (Convert.ToInt32(active));


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