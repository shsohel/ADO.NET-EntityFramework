namespace MyHRManagement.UserControls
{
    partial class EmployeesReports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewerEmp = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerEmp
            // 
            this.crystalReportViewerEmp.ActiveViewIndex = -1;
            this.crystalReportViewerEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerEmp.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerEmp.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerEmp.Name = "crystalReportViewerEmp";
            this.crystalReportViewerEmp.Size = new System.Drawing.Size(1140, 506);
            this.crystalReportViewerEmp.TabIndex = 0;
            // 
            // EmployeesReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.crystalReportViewerEmp);
            this.Name = "EmployeesReports";
            this.Size = new System.Drawing.Size(1140, 506);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerEmp;
    }
}
