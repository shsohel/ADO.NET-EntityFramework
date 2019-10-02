using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MyHRManagement.Reports;
using MyHRManagement.UserControls;

namespace MyHRManagement.UserControls
{
    public partial class EmployeesReports : UserControl
    {

        private static EmployeesReports empReports;
        public static EmployeesReports InstanceempReports
        {
            get
            {
                if (empReports == null)
                    empReports = new EmployeesReports();
                return empReports;
            }
        }

        public EmployeesReports()
        {
           
            InitializeComponent();
            rptEmployees rptemp = new rptEmployees();
            crystalReportViewerEmp.ReportSource = rptemp;
        }


       
    }
}
