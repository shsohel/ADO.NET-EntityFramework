namespace MyHRManagement.UserControls
{
    partial class UpdateDesignation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDesignation));
            this.dGVUpdateDesignation = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUpDesSearch = new System.Windows.Forms.TextBox();
            this.lblInsertDesignation = new System.Windows.Forms.Label();
            this.lblInsertID = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.btnUpdateDesignation = new System.Windows.Forms.Button();
            this.btnDeleteDesignation = new System.Windows.Forms.Button();
            this.txtBoxAddDesignation = new System.Windows.Forms.TextBox();
            this.lblDep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUpdateDesignation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVUpdateDesignation
            // 
            this.dGVUpdateDesignation.AllowUserToOrderColumns = true;
            this.dGVUpdateDesignation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUpdateDesignation.Location = new System.Drawing.Point(321, 210);
            this.dGVUpdateDesignation.Name = "dGVUpdateDesignation";
            this.dGVUpdateDesignation.Size = new System.Drawing.Size(353, 214);
            this.dGVUpdateDesignation.TabIndex = 29;
            this.dGVUpdateDesignation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVUpdateDesignation_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(791, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // txtUpDesSearch
            // 
            this.txtUpDesSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtUpDesSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpDesSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpDesSearch.ForeColor = System.Drawing.Color.Green;
            this.txtUpDesSearch.Location = new System.Drawing.Point(672, 46);
            this.txtUpDesSearch.Multiline = true;
            this.txtUpDesSearch.Name = "txtUpDesSearch";
            this.txtUpDesSearch.Size = new System.Drawing.Size(147, 28);
            this.txtUpDesSearch.TabIndex = 27;
            this.txtUpDesSearch.TextChanged += new System.EventHandler(this.txtUpDesSearch_TextChanged);
            // 
            // lblInsertDesignation
            // 
            this.lblInsertDesignation.AutoSize = true;
            this.lblInsertDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertDesignation.Location = new System.Drawing.Point(440, 139);
            this.lblInsertDesignation.Name = "lblInsertDesignation";
            this.lblInsertDesignation.Size = new System.Drawing.Size(107, 18);
            this.lblInsertDesignation.TabIndex = 26;
            this.lblInsertDesignation.Text = "Designation :";
            // 
            // lblInsertID
            // 
            this.lblInsertID.AutoSize = true;
            this.lblInsertID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertID.Location = new System.Drawing.Point(321, 139);
            this.lblInsertID.Name = "lblInsertID";
            this.lblInsertID.Size = new System.Drawing.Size(34, 18);
            this.lblInsertID.TabIndex = 25;
            this.lblInsertID.Text = "ID: ";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(321, 161);
            this.txtBoxID.Multiline = true;
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(91, 33);
            this.txtBoxID.TabIndex = 24;
            // 
            // btnUpdateDesignation
            // 
            this.btnUpdateDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDesignation.Location = new System.Drawing.Point(733, 243);
            this.btnUpdateDesignation.Name = "btnUpdateDesignation";
            this.btnUpdateDesignation.Size = new System.Drawing.Size(86, 35);
            this.btnUpdateDesignation.TabIndex = 23;
            this.btnUpdateDesignation.Text = "Update";
            this.btnUpdateDesignation.UseVisualStyleBackColor = true;
            this.btnUpdateDesignation.Click += new System.EventHandler(this.btnUpdateDesignation_Click);
            // 
            // btnDeleteDesignation
            // 
            this.btnDeleteDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDesignation.Location = new System.Drawing.Point(733, 284);
            this.btnDeleteDesignation.Name = "btnDeleteDesignation";
            this.btnDeleteDesignation.Size = new System.Drawing.Size(86, 35);
            this.btnDeleteDesignation.TabIndex = 22;
            this.btnDeleteDesignation.Text = "Delete";
            this.btnDeleteDesignation.UseVisualStyleBackColor = true;
            this.btnDeleteDesignation.Click += new System.EventHandler(this.btnDeleteDesignation_Click);
            // 
            // txtBoxAddDesignation
            // 
            this.txtBoxAddDesignation.Location = new System.Drawing.Point(440, 161);
            this.txtBoxAddDesignation.Multiline = true;
            this.txtBoxAddDesignation.Name = "txtBoxAddDesignation";
            this.txtBoxAddDesignation.Size = new System.Drawing.Size(234, 33);
            this.txtBoxAddDesignation.TabIndex = 21;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDep.Location = new System.Drawing.Point(320, 46);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(240, 24);
            this.lblDep.TabIndex = 47;
            this.lblDep.Text = "Update Designation Name";
            // 
            // UpdateDesignation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.dGVUpdateDesignation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUpDesSearch);
            this.Controls.Add(this.lblInsertDesignation);
            this.Controls.Add(this.lblInsertID);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.btnUpdateDesignation);
            this.Controls.Add(this.btnDeleteDesignation);
            this.Controls.Add(this.txtBoxAddDesignation);
            this.Name = "UpdateDesignation";
            this.Size = new System.Drawing.Size(1140, 506);
            this.Load += new System.EventHandler(this.UpdateDesignation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVUpdateDesignation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVUpdateDesignation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUpDesSearch;
        private System.Windows.Forms.Label lblInsertDesignation;
        private System.Windows.Forms.Label lblInsertID;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Button btnUpdateDesignation;
        private System.Windows.Forms.Button btnDeleteDesignation;
        private System.Windows.Forms.TextBox txtBoxAddDesignation;
        private System.Windows.Forms.Label lblDep;
    }
}
