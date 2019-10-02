namespace MyHRManagement.UserControls
{
    partial class AddDesignation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDesignation));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchDesignation = new System.Windows.Forms.TextBox();
            this.lblInsertDesignation = new System.Windows.Forms.Label();
            this.dGVAddDesignation = new System.Windows.Forms.DataGridView();
            this.btnAddDesignation = new System.Windows.Forms.Button();
            this.txtBoxAddDesignation = new System.Windows.Forms.TextBox();
            this.lblDep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAddDesignation)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(882, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearchDesignation
            // 
            this.txtSearchDesignation.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDesignation.ForeColor = System.Drawing.Color.Green;
            this.txtSearchDesignation.Location = new System.Drawing.Point(763, 38);
            this.txtSearchDesignation.Multiline = true;
            this.txtSearchDesignation.Name = "txtSearchDesignation";
            this.txtSearchDesignation.Size = new System.Drawing.Size(147, 28);
            this.txtSearchDesignation.TabIndex = 16;
            this.txtSearchDesignation.TextChanged += new System.EventHandler(this.txtSearchDesignation_TextChanged);
            // 
            // lblInsertDesignation
            // 
            this.lblInsertDesignation.AutoSize = true;
            this.lblInsertDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertDesignation.Location = new System.Drawing.Point(277, 136);
            this.lblInsertDesignation.Name = "lblInsertDesignation";
            this.lblInsertDesignation.Size = new System.Drawing.Size(107, 18);
            this.lblInsertDesignation.TabIndex = 15;
            this.lblInsertDesignation.Text = "Designation :";
            // 
            // dGVAddDesignation
            // 
            this.dGVAddDesignation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAddDesignation.Location = new System.Drawing.Point(397, 170);
            this.dGVAddDesignation.Name = "dGVAddDesignation";
            this.dGVAddDesignation.Size = new System.Drawing.Size(350, 214);
            this.dGVAddDesignation.TabIndex = 13;
            // 
            // btnAddDesignation
            // 
            this.btnAddDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDesignation.Location = new System.Drawing.Point(661, 129);
            this.btnAddDesignation.Name = "btnAddDesignation";
            this.btnAddDesignation.Size = new System.Drawing.Size(86, 35);
            this.btnAddDesignation.TabIndex = 12;
            this.btnAddDesignation.Text = "Add";
            this.btnAddDesignation.UseVisualStyleBackColor = true;
            this.btnAddDesignation.Click += new System.EventHandler(this.btnAddDesignation_Click);
            // 
            // txtBoxAddDesignation
            // 
            this.txtBoxAddDesignation.Location = new System.Drawing.Point(397, 129);
            this.txtBoxAddDesignation.Multiline = true;
            this.txtBoxAddDesignation.Name = "txtBoxAddDesignation";
            this.txtBoxAddDesignation.Size = new System.Drawing.Size(234, 33);
            this.txtBoxAddDesignation.TabIndex = 11;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDep.Location = new System.Drawing.Point(457, 42);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(201, 24);
            this.lblDep.TabIndex = 34;
            this.lblDep.Text = "Add New Designation";
            // 
            // AddDesignation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearchDesignation);
            this.Controls.Add(this.lblInsertDesignation);
            this.Controls.Add(this.dGVAddDesignation);
            this.Controls.Add(this.btnAddDesignation);
            this.Controls.Add(this.txtBoxAddDesignation);
            this.Name = "AddDesignation";
            this.Size = new System.Drawing.Size(1140, 506);
            this.Load += new System.EventHandler(this.AddDesignation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAddDesignation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchDesignation;
        private System.Windows.Forms.Label lblInsertDesignation;
        private System.Windows.Forms.DataGridView dGVAddDesignation;
        private System.Windows.Forms.Button btnAddDesignation;
        private System.Windows.Forms.TextBox txtBoxAddDesignation;
        private System.Windows.Forms.Label lblDep;
    }
}
