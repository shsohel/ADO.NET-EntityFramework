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
using MyHRManagement.Forms;
using System.Configuration;
using MyHRManagement.UserControls;

namespace MyHRManagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelHome.Controls.Contains(HomePage.Instancehpg))
            {
                panelHome.Controls.Add(HomePage.Instancehpg);
                HomePage.Instancehpg.Dock = DockStyle.Fill;
                HomePage.Instancehpg.BringToFront();
            }
            else
            {
                HomePage.Instancehpg.BringToFront();
            }
        }

        private void addDesignationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!panelHome.Controls.Contains(AddDesignation.Instance))
            {
                panelHome.Controls.Add(AddDesignation.Instance);
                AddDesignation.Instance.Dock = DockStyle.Fill;
                AddDesignation.Instance.BringToFront();
            }
            else
            {
                AddDesignation.Instance.BringToFront();
            }
        }

        private void updateDesignationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelHome.Controls.Contains(UpdateDesignation.InstanceUpDes))
            {
                panelHome.Controls.Add(UpdateDesignation.InstanceUpDes);
                UpdateDesignation.InstanceUpDes.Dock = DockStyle.Fill;
                UpdateDesignation.InstanceUpDes.BringToFront();
            }
            else
            {
                UpdateDesignation.InstanceUpDes.BringToFront();
            }
        }

        private void addDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelHome.Controls.Contains(AddDepartment.InstanceDP))
            {
                panelHome.Controls.Add(AddDepartment.InstanceDP);
                AddDepartment.InstanceDP.Dock = DockStyle.Fill;
                AddDepartment.InstanceDP.BringToFront();
            }
            else
            {
                AddDepartment.InstanceDP.BringToFront();
            }
        }

        private void updateDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelHome.Controls.Contains(UpdateDepartment.InstanceUDP))
            {
                panelHome.Controls.Add(UpdateDepartment.InstanceUDP);
                UpdateDepartment.InstanceUDP.Dock = DockStyle.Fill;
                UpdateDepartment.InstanceUDP.BringToFront();
            }
            else
            {
                UpdateDepartment.InstanceUDP.BringToFront();
            }
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelHome.Controls.Contains(AddEmployee.InAddEmployee))
            {
                panelHome.Controls.Add(AddEmployee.InAddEmployee);
                AddEmployee.InAddEmployee.Dock = DockStyle.Fill;
                AddEmployee.InAddEmployee.BringToFront();
            }
            else
            {
                AddEmployee.InAddEmployee.BringToFront();
            }
        }

        private void departmentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelHome.Controls.Contains(DepartmentReport.InstanceRD))
            {
                panelHome.Controls.Add(DepartmentReport.InstanceRD);
                DepartmentReport.InstanceRD.Dock = DockStyle.Fill;
                DepartmentReport.InstanceRD.BringToFront();
            }
            else
            {
                DepartmentReport.InstanceRD.BringToFront();
            }
        }

        private void btnHomeExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelHome.Controls.Contains(UpdateEmployee.InupdateEmployee))
            {
                panelHome.Controls.Add(UpdateEmployee.InupdateEmployee);
                UpdateEmployee.InupdateEmployee.Dock = DockStyle.Fill;
                UpdateEmployee.InupdateEmployee.BringToFront();
            }
            else
            {
                UpdateEmployee.InupdateEmployee.BringToFront();
            }
        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelHome.Controls.Contains(EmployeesReports.InstanceempReports))
            {
                panelHome.Controls.Add(EmployeesReports.InstanceempReports);
                EmployeesReports.InstanceempReports.Dock = DockStyle.Fill;
                EmployeesReports.InstanceempReports.BringToFront();
            }
            else
            {
                EmployeesReports.InstanceempReports.BringToFront();
            }
        }

        private void lblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Close();
            Login llout = new Login();
            llout.Show();
        }
    }
}
