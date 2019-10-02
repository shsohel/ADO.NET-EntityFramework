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
    public partial class AddDesignation : UserControl
    {
        //Connectiong String Link here
        string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;


        //DataTable Gobal Variable 
        DataTable dtDesignation;


        private static AddDesignation _instance;
        public static AddDesignation Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddDesignation();
                return _instance;
            }
        }

        public AddDesignation()
        {
            InitializeComponent();
        }

        private void AddDesignation_Load(object sender, EventArgs e)
        {
             GetDesignationList();
        }

        private DataTable GetDesignationList()
        {            
            SqlConnection con = new SqlConnection(cs);

            con.Open();

            string showQry = "SELECT*FROM SGHR.HrDesignation";
            SqlCommand cmd = new SqlCommand(showQry, con);           
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dtDesignation = new DataTable();
            da.Fill(dtDesignation);
            dGVAddDesignation.DataSource = dtDesignation.DefaultView;

            con.Close();

            return dtDesignation;
        }

        //Search Value By Name in Designation Table 
        private void txtSearchDesignation_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtDesignation);
            DV.RowFilter = string.Format("DegName LIKE '%{0}%'", txtSearchDesignation.Text);
            dGVAddDesignation.DataSource = DV;
        }


        //Insert Data on Designation Table
        private void btnAddDesignation_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
                if (txtBoxAddDesignation.Text != "")
                {
                    con.Open();

                    string qry = " INSERT INTO SGHR.HrDesignation (DegName) VALUES (@degname)";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@degname", txtBoxAddDesignation.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record saved successfully!!!");

                    //Clear Text Box After Data Inserted 
                    txtBoxAddDesignation.Text = "";

                    con.Close();

                    //Data Load 
                    con.Open();

                    string showQry = "SELECT*FROM SGHR.HrDesignation";
                    cmd = new SqlCommand(showQry, con);
                    dtDesignation = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtDesignation);
                    dGVAddDesignation.DataSource = dtDesignation.DefaultView;

                    con.Close();

                }
                else
                {
                    MessageBox.Show("Please Provide Designation Name ");
                }
        }
    }
    
}
