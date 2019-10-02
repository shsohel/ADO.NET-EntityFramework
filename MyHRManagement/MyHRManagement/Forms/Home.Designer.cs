namespace MyHRManagement
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelHome = new System.Windows.Forms.Panel();
            this.lblLogOut = new System.Windows.Forms.LinkLabel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDesignationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDesignationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLeaveTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLeaveStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVacancyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addInterviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLeaveRosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designationReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHomeExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHome.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.pictureBox1);
            this.panelHome.Controls.Add(this.lblLogOut);
            this.panelHome.Controls.Add(this.menuStripMain);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Location = new System.Drawing.Point(2, 3);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1141, 506);
            this.panelHome.TabIndex = 4;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.Location = new System.Drawing.Point(1086, 44);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(46, 13);
            this.lblLogOut.TabIndex = 6;
            this.lblLogOut.TabStop = true;
            this.lblLogOut.Text = "Logout";
            this.lblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogOut_LinkClicked);
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStripMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStripMain.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.addNewToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripMain.Size = new System.Drawing.Size(1141, 32);
            this.menuStripMain.TabIndex = 5;
            this.menuStripMain.Text = "menuStripMainHome";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(57, 28);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.designationToolStripMenuItem,
            this.addDepartmentToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.addLeaveToolStripMenuItem,
            this.addLeaveTypeToolStripMenuItem,
            this.addLeaveStatusToolStripMenuItem,
            this.addEventToolStripMenuItem,
            this.addProjectToolStripMenuItem,
            this.addVacancyToolStripMenuItem,
            this.addInterviewToolStripMenuItem,
            this.addLeaveRosterToolStripMenuItem});
            this.addNewToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.addNewToolStripMenuItem.Text = "Add New";
            // 
            // designationToolStripMenuItem
            // 
            this.designationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDesignationToolStripMenuItem,
            this.updateDesignationToolStripMenuItem});
            this.designationToolStripMenuItem.Name = "designationToolStripMenuItem";
            this.designationToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.designationToolStripMenuItem.Text = "Designation";
            // 
            // addDesignationToolStripMenuItem
            // 
            this.addDesignationToolStripMenuItem.Name = "addDesignationToolStripMenuItem";
            this.addDesignationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.addDesignationToolStripMenuItem.Text = "Add Designation";
            this.addDesignationToolStripMenuItem.Click += new System.EventHandler(this.addDesignationToolStripMenuItem_Click);
            // 
            // updateDesignationToolStripMenuItem
            // 
            this.updateDesignationToolStripMenuItem.Name = "updateDesignationToolStripMenuItem";
            this.updateDesignationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.updateDesignationToolStripMenuItem.Text = "Update Designation";
            this.updateDesignationToolStripMenuItem.Click += new System.EventHandler(this.updateDesignationToolStripMenuItem_Click);
            // 
            // addDepartmentToolStripMenuItem
            // 
            this.addDepartmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDToolStripMenuItem,
            this.updateDepartmentToolStripMenuItem});
            this.addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
            this.addDepartmentToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addDepartmentToolStripMenuItem.Text = "Department";
            // 
            // addDToolStripMenuItem
            // 
            this.addDToolStripMenuItem.Name = "addDToolStripMenuItem";
            this.addDToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.addDToolStripMenuItem.Text = "Add Department";
            this.addDToolStripMenuItem.Click += new System.EventHandler(this.addDToolStripMenuItem_Click);
            // 
            // updateDepartmentToolStripMenuItem
            // 
            this.updateDepartmentToolStripMenuItem.Name = "updateDepartmentToolStripMenuItem";
            this.updateDepartmentToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.updateDepartmentToolStripMenuItem.Text = "Update Department";
            this.updateDepartmentToolStripMenuItem.Click += new System.EventHandler(this.updateDepartmentToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.updateEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // updateEmployeeToolStripMenuItem
            // 
            this.updateEmployeeToolStripMenuItem.Name = "updateEmployeeToolStripMenuItem";
            this.updateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.updateEmployeeToolStripMenuItem.Text = "Update Employee";
            this.updateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeToolStripMenuItem_Click);
            // 
            // addLeaveToolStripMenuItem
            // 
            this.addLeaveToolStripMenuItem.Name = "addLeaveToolStripMenuItem";
            this.addLeaveToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addLeaveToolStripMenuItem.Text = "Add Leave";
            // 
            // addLeaveTypeToolStripMenuItem
            // 
            this.addLeaveTypeToolStripMenuItem.Name = "addLeaveTypeToolStripMenuItem";
            this.addLeaveTypeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addLeaveTypeToolStripMenuItem.Text = "Add Leave Type";
            // 
            // addLeaveStatusToolStripMenuItem
            // 
            this.addLeaveStatusToolStripMenuItem.Name = "addLeaveStatusToolStripMenuItem";
            this.addLeaveStatusToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addLeaveStatusToolStripMenuItem.Text = "Add Leave Status";
            // 
            // addEventToolStripMenuItem
            // 
            this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addEventToolStripMenuItem.Text = "Add Event";
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addProjectToolStripMenuItem.Text = "Add Project";
            // 
            // addVacancyToolStripMenuItem
            // 
            this.addVacancyToolStripMenuItem.Name = "addVacancyToolStripMenuItem";
            this.addVacancyToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addVacancyToolStripMenuItem.Text = "Add Vacancy";
            // 
            // addInterviewToolStripMenuItem
            // 
            this.addInterviewToolStripMenuItem.Name = "addInterviewToolStripMenuItem";
            this.addInterviewToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addInterviewToolStripMenuItem.Text = "Add Interview";
            // 
            // addLeaveRosterToolStripMenuItem
            // 
            this.addLeaveRosterToolStripMenuItem.Name = "addLeaveRosterToolStripMenuItem";
            this.addLeaveRosterToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addLeaveRosterToolStripMenuItem.Text = "Add Leave Roster";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentReportToolStripMenuItem,
            this.designationReportToolStripMenuItem,
            this.employeeReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(68, 28);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // departmentReportToolStripMenuItem
            // 
            this.departmentReportToolStripMenuItem.Name = "departmentReportToolStripMenuItem";
            this.departmentReportToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.departmentReportToolStripMenuItem.Text = "Department Report";
            this.departmentReportToolStripMenuItem.Click += new System.EventHandler(this.departmentReportToolStripMenuItem_Click);
            // 
            // designationReportToolStripMenuItem
            // 
            this.designationReportToolStripMenuItem.Name = "designationReportToolStripMenuItem";
            this.designationReportToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.designationReportToolStripMenuItem.Text = "Designation Report";
            // 
            // employeeReportToolStripMenuItem
            // 
            this.employeeReportToolStripMenuItem.Name = "employeeReportToolStripMenuItem";
            this.employeeReportToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.employeeReportToolStripMenuItem.Text = "Employee Report";
            this.employeeReportToolStripMenuItem.Click += new System.EventHandler(this.employeeReportToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(318, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to SG Human Resource ";
            // 
            // btnHomeExit
            // 
            this.btnHomeExit.Location = new System.Drawing.Point(1065, 510);
            this.btnHomeExit.Name = "btnHomeExit";
            this.btnHomeExit.Size = new System.Drawing.Size(75, 23);
            this.btnHomeExit.TabIndex = 5;
            this.btnHomeExit.Text = "Exit";
            this.btnHomeExit.UseVisualStyleBackColor = true;
            this.btnHomeExit.Click += new System.EventHandler(this.btnHomeExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1104, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 533);
            this.Controls.Add(this.btnHomeExit);
            this.Controls.Add(this.panelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHomeExit;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDesignationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDesignationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLeaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLeaveTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLeaveStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVacancyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addInterviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLeaveRosterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designationReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeReportToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lblLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

