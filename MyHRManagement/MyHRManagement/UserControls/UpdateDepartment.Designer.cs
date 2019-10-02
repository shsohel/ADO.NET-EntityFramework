namespace MyHRManagement.UserControls
{
    partial class UpdateDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDepartment));
            this.lblOperationDepart = new System.Windows.Forms.Label();
            this.cmBoxUpOperation = new System.Windows.Forms.ComboBox();
            this.DGVUpDepartment = new System.Windows.Forms.DataGridView();
            this.txtBoxUpDepartDesc = new System.Windows.Forms.TextBox();
            this.txtBoxUpDepartType = new System.Windows.Forms.TextBox();
            this.txtBoxUpDepartName = new System.Windows.Forms.TextBox();
            this.txtBoxUpDepartID = new System.Windows.Forms.TextBox();
            this.btnUpSubmitDepartment = new System.Windows.Forms.Button();
            this.lblDepartName = new System.Windows.Forms.Label();
            this.lblDepartType = new System.Windows.Forms.Label();
            this.lblDepartDesc = new System.Windows.Forms.Label();
            this.lblDepartmentID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchDept = new System.Windows.Forms.TextBox();
            this.lblDep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUpDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOperationDepart
            // 
            this.lblOperationDepart.AutoSize = true;
            this.lblOperationDepart.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperationDepart.Location = new System.Drawing.Point(152, 300);
            this.lblOperationDepart.Name = "lblOperationDepart";
            this.lblOperationDepart.Size = new System.Drawing.Size(146, 22);
            this.lblOperationDepart.TabIndex = 43;
            this.lblOperationDepart.Text = "Select Operation : ";
            // 
            // cmBoxUpOperation
            // 
            this.cmBoxUpOperation.FormattingEnabled = true;
            this.cmBoxUpOperation.Items.AddRange(new object[] {
            "UPDATE",
            "DELETE"});
            this.cmBoxUpOperation.Location = new System.Drawing.Point(310, 300);
            this.cmBoxUpOperation.Name = "cmBoxUpOperation";
            this.cmBoxUpOperation.Size = new System.Drawing.Size(208, 21);
            this.cmBoxUpOperation.TabIndex = 42;
            // 
            // DGVUpDepartment
            // 
            this.DGVUpDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUpDepartment.Location = new System.Drawing.Point(543, 98);
            this.DGVUpDepartment.Name = "DGVUpDepartment";
            this.DGVUpDepartment.Size = new System.Drawing.Size(446, 310);
            this.DGVUpDepartment.TabIndex = 41;
            this.DGVUpDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUpDepartment_CellClick);
            // 
            // txtBoxUpDepartDesc
            // 
            this.txtBoxUpDepartDesc.Location = new System.Drawing.Point(310, 230);
            this.txtBoxUpDepartDesc.Multiline = true;
            this.txtBoxUpDepartDesc.Name = "txtBoxUpDepartDesc";
            this.txtBoxUpDepartDesc.Size = new System.Drawing.Size(207, 54);
            this.txtBoxUpDepartDesc.TabIndex = 40;
            // 
            // txtBoxUpDepartType
            // 
            this.txtBoxUpDepartType.Location = new System.Drawing.Point(310, 182);
            this.txtBoxUpDepartType.Multiline = true;
            this.txtBoxUpDepartType.Name = "txtBoxUpDepartType";
            this.txtBoxUpDepartType.Size = new System.Drawing.Size(207, 22);
            this.txtBoxUpDepartType.TabIndex = 39;
            // 
            // txtBoxUpDepartName
            // 
            this.txtBoxUpDepartName.Location = new System.Drawing.Point(310, 137);
            this.txtBoxUpDepartName.Multiline = true;
            this.txtBoxUpDepartName.Name = "txtBoxUpDepartName";
            this.txtBoxUpDepartName.Size = new System.Drawing.Size(207, 22);
            this.txtBoxUpDepartName.TabIndex = 38;
            // 
            // txtBoxUpDepartID
            // 
            this.txtBoxUpDepartID.Location = new System.Drawing.Point(310, 98);
            this.txtBoxUpDepartID.Multiline = true;
            this.txtBoxUpDepartID.Name = "txtBoxUpDepartID";
            this.txtBoxUpDepartID.Size = new System.Drawing.Size(207, 22);
            this.txtBoxUpDepartID.TabIndex = 37;
            // 
            // btnUpSubmitDepartment
            // 
            this.btnUpSubmitDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpSubmitDepartment.Location = new System.Drawing.Point(431, 378);
            this.btnUpSubmitDepartment.Name = "btnUpSubmitDepartment";
            this.btnUpSubmitDepartment.Size = new System.Drawing.Size(86, 30);
            this.btnUpSubmitDepartment.TabIndex = 35;
            this.btnUpSubmitDepartment.Text = "Submit";
            this.btnUpSubmitDepartment.UseVisualStyleBackColor = true;
            this.btnUpSubmitDepartment.Click += new System.EventHandler(this.btnUpSubmitDepartment_Click);
            // 
            // lblDepartName
            // 
            this.lblDepartName.AutoSize = true;
            this.lblDepartName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartName.Location = new System.Drawing.Point(151, 137);
            this.lblDepartName.Name = "lblDepartName";
            this.lblDepartName.Size = new System.Drawing.Size(157, 22);
            this.lblDepartName.TabIndex = 34;
            this.lblDepartName.Text = "Department Name: ";
            // 
            // lblDepartType
            // 
            this.lblDepartType.AutoSize = true;
            this.lblDepartType.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartType.Location = new System.Drawing.Point(152, 182);
            this.lblDepartType.Name = "lblDepartType";
            this.lblDepartType.Size = new System.Drawing.Size(151, 22);
            this.lblDepartType.TabIndex = 33;
            this.lblDepartType.Text = "Department Type: ";
            // 
            // lblDepartDesc
            // 
            this.lblDepartDesc.AutoSize = true;
            this.lblDepartDesc.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartDesc.Location = new System.Drawing.Point(151, 227);
            this.lblDepartDesc.Name = "lblDepartDesc";
            this.lblDepartDesc.Size = new System.Drawing.Size(105, 22);
            this.lblDepartDesc.TabIndex = 32;
            this.lblDepartDesc.Text = "Description: ";
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentID.Location = new System.Drawing.Point(151, 98);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(41, 22);
            this.lblDepartmentID.TabIndex = 31;
            this.lblDepartmentID.Text = "ID : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(961, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearchDept
            // 
            this.txtSearchDept.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDept.ForeColor = System.Drawing.Color.Green;
            this.txtSearchDept.Location = new System.Drawing.Point(842, 25);
            this.txtSearchDept.Multiline = true;
            this.txtSearchDept.Name = "txtSearchDept";
            this.txtSearchDept.Size = new System.Drawing.Size(147, 28);
            this.txtSearchDept.TabIndex = 44;
            this.txtSearchDept.TextChanged += new System.EventHandler(this.txtSearchDept_TextChanged);
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDep.Location = new System.Drawing.Point(442, 25);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(292, 24);
            this.lblDep.TabIndex = 46;
            this.lblDep.Text = "Update Department Information";
            // 
            // UpdateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearchDept);
            this.Controls.Add(this.lblOperationDepart);
            this.Controls.Add(this.cmBoxUpOperation);
            this.Controls.Add(this.DGVUpDepartment);
            this.Controls.Add(this.txtBoxUpDepartDesc);
            this.Controls.Add(this.txtBoxUpDepartType);
            this.Controls.Add(this.txtBoxUpDepartName);
            this.Controls.Add(this.txtBoxUpDepartID);
            this.Controls.Add(this.btnUpSubmitDepartment);
            this.Controls.Add(this.lblDepartName);
            this.Controls.Add(this.lblDepartType);
            this.Controls.Add(this.lblDepartDesc);
            this.Controls.Add(this.lblDepartmentID);
            this.Name = "UpdateDepartment";
            this.Size = new System.Drawing.Size(1140, 506);
            this.Load += new System.EventHandler(this.UpdateDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUpDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperationDepart;
        private System.Windows.Forms.ComboBox cmBoxUpOperation;
        private System.Windows.Forms.DataGridView DGVUpDepartment;
        private System.Windows.Forms.TextBox txtBoxUpDepartDesc;
        private System.Windows.Forms.TextBox txtBoxUpDepartType;
        private System.Windows.Forms.TextBox txtBoxUpDepartName;
        private System.Windows.Forms.TextBox txtBoxUpDepartID;
        private System.Windows.Forms.Button btnUpSubmitDepartment;
        private System.Windows.Forms.Label lblDepartName;
        private System.Windows.Forms.Label lblDepartType;
        private System.Windows.Forms.Label lblDepartDesc;
        private System.Windows.Forms.Label lblDepartmentID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchDept;
        private System.Windows.Forms.Label lblDep;
    }
}
