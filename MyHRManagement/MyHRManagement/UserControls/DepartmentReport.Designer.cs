namespace MyHRManagement.UserControls
{
    partial class DepartmentReport
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
            this.crystalReportViewerDep = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblDep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crystalReportViewerDep
            // 
            this.crystalReportViewerDep.ActiveViewIndex = -1;
            this.crystalReportViewerDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerDep.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerDep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerDep.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerDep.Name = "crystalReportViewerDep";
            this.crystalReportViewerDep.Size = new System.Drawing.Size(1140, 506);
            this.crystalReportViewerDep.TabIndex = 0;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDep.Location = new System.Drawing.Point(499, 0);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(179, 24);
            this.lblDep.TabIndex = 35;
            this.lblDep.Text = "Department Report";
            // 
            // DepartmentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.crystalReportViewerDep);
            this.Name = "DepartmentReport";
            this.Size = new System.Drawing.Size(1140, 506);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerDep;
        private System.Windows.Forms.Label lblDep;
    }
}
