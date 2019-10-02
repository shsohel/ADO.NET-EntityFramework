namespace MyHRManagement.UserControls
{
    partial class AddDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDepartment));
            this.lblOperationDepart = new System.Windows.Forms.Label();
            this.cmBoxOperation = new System.Windows.Forms.ComboBox();
            this.DGVDepartment = new System.Windows.Forms.DataGridView();
            this.txtBoxDepartDesc = new System.Windows.Forms.TextBox();
            this.txtBoxDepartType = new System.Windows.Forms.TextBox();
            this.txtBoxDepartName = new System.Windows.Forms.TextBox();
            this.btnSubmitDepartment = new System.Windows.Forms.Button();
            this.lblDepartName = new System.Windows.Forms.Label();
            this.lblDepartType = new System.Windows.Forms.Label();
            this.lblDepartDesc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchDept = new System.Windows.Forms.TextBox();
            this.lblDep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOperationDepart
            // 
            this.lblOperationDepart.AutoSize = true;
            this.lblOperationDepart.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperationDepart.Location = new System.Drawing.Point(141, 300);
            this.lblOperationDepart.Name = "lblOperationDepart";
            this.lblOperationDepart.Size = new System.Drawing.Size(146, 22);
            this.lblOperationDepart.TabIndex = 30;
            this.lblOperationDepart.Text = "Select Operation : ";
            // 
            // cmBoxOperation
            // 
            this.cmBoxOperation.FormattingEnabled = true;
            this.cmBoxOperation.Items.AddRange(new object[] {
            "INSERT"});
            this.cmBoxOperation.Location = new System.Drawing.Point(299, 300);
            this.cmBoxOperation.Name = "cmBoxOperation";
            this.cmBoxOperation.Size = new System.Drawing.Size(208, 21);
            this.cmBoxOperation.TabIndex = 29;
            // 
            // DGVDepartment
            // 
            this.DGVDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDepartment.Location = new System.Drawing.Point(532, 137);
            this.DGVDepartment.Name = "DGVDepartment";
            this.DGVDepartment.Size = new System.Drawing.Size(446, 271);
            this.DGVDepartment.TabIndex = 28;
            // 
            // txtBoxDepartDesc
            // 
            this.txtBoxDepartDesc.Location = new System.Drawing.Point(299, 230);
            this.txtBoxDepartDesc.Multiline = true;
            this.txtBoxDepartDesc.Name = "txtBoxDepartDesc";
            this.txtBoxDepartDesc.Size = new System.Drawing.Size(207, 54);
            this.txtBoxDepartDesc.TabIndex = 27;
            // 
            // txtBoxDepartType
            // 
            this.txtBoxDepartType.Location = new System.Drawing.Point(299, 182);
            this.txtBoxDepartType.Multiline = true;
            this.txtBoxDepartType.Name = "txtBoxDepartType";
            this.txtBoxDepartType.Size = new System.Drawing.Size(207, 22);
            this.txtBoxDepartType.TabIndex = 26;
            // 
            // txtBoxDepartName
            // 
            this.txtBoxDepartName.Location = new System.Drawing.Point(299, 137);
            this.txtBoxDepartName.Multiline = true;
            this.txtBoxDepartName.Name = "txtBoxDepartName";
            this.txtBoxDepartName.Size = new System.Drawing.Size(207, 22);
            this.txtBoxDepartName.TabIndex = 25;
            // 
            // btnSubmitDepartment
            // 
            this.btnSubmitDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitDepartment.Location = new System.Drawing.Point(420, 378);
            this.btnSubmitDepartment.Name = "btnSubmitDepartment";
            this.btnSubmitDepartment.Size = new System.Drawing.Size(86, 30);
            this.btnSubmitDepartment.TabIndex = 22;
            this.btnSubmitDepartment.Text = "Submit";
            this.btnSubmitDepartment.UseVisualStyleBackColor = true;
            this.btnSubmitDepartment.Click += new System.EventHandler(this.btnSubmitDepartment_Click);
            // 
            // lblDepartName
            // 
            this.lblDepartName.AutoSize = true;
            this.lblDepartName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartName.Location = new System.Drawing.Point(140, 137);
            this.lblDepartName.Name = "lblDepartName";
            this.lblDepartName.Size = new System.Drawing.Size(157, 22);
            this.lblDepartName.TabIndex = 21;
            this.lblDepartName.Text = "Department Name: ";
            // 
            // lblDepartType
            // 
            this.lblDepartType.AutoSize = true;
            this.lblDepartType.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartType.Location = new System.Drawing.Point(141, 182);
            this.lblDepartType.Name = "lblDepartType";
            this.lblDepartType.Size = new System.Drawing.Size(151, 22);
            this.lblDepartType.TabIndex = 20;
            this.lblDepartType.Text = "Department Type: ";
            // 
            // lblDepartDesc
            // 
            this.lblDepartDesc.AutoSize = true;
            this.lblDepartDesc.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartDesc.Location = new System.Drawing.Point(140, 227);
            this.lblDepartDesc.Name = "lblDepartDesc";
            this.lblDepartDesc.Size = new System.Drawing.Size(105, 22);
            this.lblDepartDesc.TabIndex = 19;
            this.lblDepartDesc.Text = "Description: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(950, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearchDept
            // 
            this.txtSearchDept.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDept.ForeColor = System.Drawing.Color.Green;
            this.txtSearchDept.Location = new System.Drawing.Point(831, 37);
            this.txtSearchDept.Multiline = true;
            this.txtSearchDept.Name = "txtSearchDept";
            this.txtSearchDept.Size = new System.Drawing.Size(147, 28);
            this.txtSearchDept.TabIndex = 31;
            this.txtSearchDept.TextChanged += new System.EventHandler(this.txtSearchDept_TextChanged);
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDep.Location = new System.Drawing.Point(472, 41);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(202, 24);
            this.lblDep.TabIndex = 33;
            this.lblDep.Text = "Add New Department";
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearchDept);
            this.Controls.Add(this.lblOperationDepart);
            this.Controls.Add(this.cmBoxOperation);
            this.Controls.Add(this.DGVDepartment);
            this.Controls.Add(this.txtBoxDepartDesc);
            this.Controls.Add(this.txtBoxDepartType);
            this.Controls.Add(this.txtBoxDepartName);
            this.Controls.Add(this.btnSubmitDepartment);
            this.Controls.Add(this.lblDepartName);
            this.Controls.Add(this.lblDepartType);
            this.Controls.Add(this.lblDepartDesc);
            this.Name = "AddDepartment";
            this.Size = new System.Drawing.Size(1140, 506);
            this.Load += new System.EventHandler(this.AddDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperationDepart;
        private System.Windows.Forms.ComboBox cmBoxOperation;
        private System.Windows.Forms.DataGridView DGVDepartment;
        private System.Windows.Forms.TextBox txtBoxDepartDesc;
        private System.Windows.Forms.TextBox txtBoxDepartType;
        private System.Windows.Forms.TextBox txtBoxDepartName;
        private System.Windows.Forms.Button btnSubmitDepartment;
        private System.Windows.Forms.Label lblDepartName;
        private System.Windows.Forms.Label lblDepartType;
        private System.Windows.Forms.Label lblDepartDesc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchDept;
        private System.Windows.Forms.Label lblDep;
    }
}
