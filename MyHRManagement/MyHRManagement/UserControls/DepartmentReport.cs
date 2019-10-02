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
    public partial class DepartmentReport : UserControl
    {
        private static DepartmentReport _instancerd;
        public static DepartmentReport InstanceRD
        {
            get
            {
                if (_instancerd == null)
                    _instancerd = new DepartmentReport();
                return _instancerd;
            }
        }

        public DepartmentReport()
        {
            InitializeComponent();
            rDepartmentReport rptDept= new rDepartmentReport();
            crystalReportViewerDep.ReportSource = rptDept;
        }
    }
}
