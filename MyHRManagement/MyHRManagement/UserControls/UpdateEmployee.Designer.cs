namespace MyHRManagement.UserControls
{
    partial class UpdateEmployee
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
            this.txtPicLocation = new System.Windows.Forms.TextBox();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.checkBoxNo = new System.Windows.Forms.CheckBox();
            this.btnPicUpload = new System.Windows.Forms.Button();
            this.btnSubmitEmployee = new System.Windows.Forms.Button();
            this.DGVEmployee = new System.Windows.Forms.DataGridView();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.txtEmpAddress = new System.Windows.Forms.TextBox();
            this.checkboxYes = new System.Windows.Forms.CheckBox();
            this.dtpEmpTerDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEmpJoinDate = new System.Windows.Forms.DateTimePicker();
            this.txtEmpBloodGroup = new System.Windows.Forms.TextBox();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.comboBoxMarital = new System.Windows.Forms.ComboBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.txtEmpLastName = new System.Windows.Forms.TextBox();
            this.txtEmpFirstName = new System.Windows.Forms.TextBox();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.comboBoxDes = new System.Windows.Forms.ComboBox();
            this.lblEmpActive = new System.Windows.Forms.Label();
            this.lblEmpDesignationID = new System.Windows.Forms.Label();
            this.lblEmpTermination = new System.Windows.Forms.Label();
            this.lblEmpAddress = new System.Windows.Forms.Label();
            this.lblEmpEmail = new System.Windows.Forms.Label();
            this.lblEmpDOB = new System.Windows.Forms.Label();
            this.lblEmpMaried = new System.Windows.Forms.Label();
            this.lblEmpGender = new System.Windows.Forms.Label();
            this.lblEmpLastName = new System.Windows.Forms.Label();
            this.lblEmpBlood = new System.Windows.Forms.Label();
            this.lblEmpJoin = new System.Windows.Forms.Label();
            this.lblEmpDepartID = new System.Windows.Forms.Label();
            this.lblEmpCellPhone = new System.Windows.Forms.Label();
            this.lblEmpFirstName = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lblDep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPicLocation
            // 
            this.txtPicLocation.Location = new System.Drawing.Point(925, 175);
            this.txtPicLocation.Name = "txtPicLocation";
            this.txtPicLocation.Size = new System.Drawing.Size(99, 20);
            this.txtPicLocation.TabIndex = 115;
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Items.AddRange(new object[] {
            "UPDATE",
            "DELETE"});
            this.comboBoxOperation.Location = new System.Drawing.Point(771, 232);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(172, 21);
            this.comboBoxOperation.TabIndex = 114;
            this.comboBoxOperation.Text = "Select a Operation";
            // 
            // checkBoxNo
            // 
            this.checkBoxNo.AutoSize = true;
            this.checkBoxNo.Location = new System.Drawing.Point(853, 185);
            this.checkBoxNo.Name = "checkBoxNo";
            this.checkBoxNo.Size = new System.Drawing.Size(40, 17);
            this.checkBoxNo.TabIndex = 113;
            this.checkBoxNo.Text = "No";
            this.checkBoxNo.UseVisualStyleBackColor = true;
            this.checkBoxNo.CheckedChanged += new System.EventHandler(this.checkBoxNo_CheckedChanged);
            // 
            // btnPicUpload
            // 
            this.btnPicUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPicUpload.Location = new System.Drawing.Point(925, 146);
            this.btnPicUpload.Name = "btnPicUpload";
            this.btnPicUpload.Size = new System.Drawing.Size(99, 23);
            this.btnPicUpload.TabIndex = 112;
            this.btnPicUpload.Text = "Upload Photo";
            this.btnPicUpload.UseVisualStyleBackColor = true;
            this.btnPicUpload.Click += new System.EventHandler(this.btnPicUpload_Click);
            // 
            // btnSubmitEmployee
            // 
            this.btnSubmitEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitEmployee.Location = new System.Drawing.Point(949, 232);
            this.btnSubmitEmployee.Name = "btnSubmitEmployee";
            this.btnSubmitEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitEmployee.TabIndex = 111;
            this.btnSubmitEmployee.Text = "Submit";
            this.btnSubmitEmployee.UseVisualStyleBackColor = true;
            this.btnSubmitEmployee.Click += new System.EventHandler(this.btnSubmitEmployee_Click);
            // 
            // DGVEmployee
            // 
            this.DGVEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGVEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmployee.Location = new System.Drawing.Point(12, 261);
            this.DGVEmployee.Name = "DGVEmployee";
            this.DGVEmployee.RowHeadersWidth = 18;
            this.DGVEmployee.Size = new System.Drawing.Size(1117, 190);
            this.DGVEmployee.TabIndex = 110;
            this.DGVEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEmployee_CellClick);
            // 
            // picEmployee
            // 
            this.picEmployee.BackColor = System.Drawing.Color.LemonChiffon;
            this.picEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEmployee.Location = new System.Drawing.Point(925, 55);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(99, 85);
            this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmployee.TabIndex = 109;
            this.picEmployee.TabStop = false;
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.Location = new System.Drawing.Point(200, 183);
            this.txtEmpAddress.Multiline = true;
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.Size = new System.Drawing.Size(223, 54);
            this.txtEmpAddress.TabIndex = 108;
            // 
            // checkboxYes
            // 
            this.checkboxYes.AutoSize = true;
            this.checkboxYes.Location = new System.Drawing.Point(810, 185);
            this.checkboxYes.Name = "checkboxYes";
            this.checkboxYes.Size = new System.Drawing.Size(44, 17);
            this.checkboxYes.TabIndex = 107;
            this.checkboxYes.Text = "Yes";
            this.checkboxYes.UseVisualStyleBackColor = true;
            this.checkboxYes.CheckedChanged += new System.EventHandler(this.checkboxYes_CheckedChanged);
            // 
            // dtpEmpTerDate
            // 
            this.dtpEmpTerDate.Location = new System.Drawing.Point(709, 152);
            this.dtpEmpTerDate.Name = "dtpEmpTerDate";
            this.dtpEmpTerDate.Size = new System.Drawing.Size(184, 20);
            this.dtpEmpTerDate.TabIndex = 106;
            // 
            // dtpEmpJoinDate
            // 
            this.dtpEmpJoinDate.Location = new System.Drawing.Point(426, 152);
            this.dtpEmpJoinDate.Name = "dtpEmpJoinDate";
            this.dtpEmpJoinDate.Size = new System.Drawing.Size(139, 20);
            this.dtpEmpJoinDate.TabIndex = 105;
            // 
            // txtEmpBloodGroup
            // 
            this.txtEmpBloodGroup.Location = new System.Drawing.Point(200, 152);
            this.txtEmpBloodGroup.Name = "txtEmpBloodGroup";
            this.txtEmpBloodGroup.Size = new System.Drawing.Size(111, 20);
            this.txtEmpBloodGroup.TabIndex = 104;
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(751, 120);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(143, 20);
            this.txtEmpEmail.TabIndex = 103;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(426, 120);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(246, 20);
            this.dtpDOB.TabIndex = 102;
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.Location = new System.Drawing.Point(200, 120);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(111, 20);
            this.txtEmpPhone.TabIndex = 101;
            // 
            // comboBoxMarital
            // 
            this.comboBoxMarital.FormattingEnabled = true;
            this.comboBoxMarital.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Devorced"});
            this.comboBoxMarital.Location = new System.Drawing.Point(810, 55);
            this.comboBoxMarital.Name = "comboBoxMarital";
            this.comboBoxMarital.Size = new System.Drawing.Size(83, 21);
            this.comboBoxMarital.TabIndex = 100;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.comboBoxGender.Location = new System.Drawing.Point(590, 87);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(82, 21);
            this.comboBoxGender.TabIndex = 99;
            // 
            // txtEmpLastName
            // 
            this.txtEmpLastName.Location = new System.Drawing.Point(403, 87);
            this.txtEmpLastName.Name = "txtEmpLastName";
            this.txtEmpLastName.Size = new System.Drawing.Size(111, 20);
            this.txtEmpLastName.TabIndex = 98;
            // 
            // txtEmpFirstName
            // 
            this.txtEmpFirstName.Location = new System.Drawing.Point(200, 87);
            this.txtEmpFirstName.Name = "txtEmpFirstName";
            this.txtEmpFirstName.Size = new System.Drawing.Size(111, 20);
            this.txtEmpFirstName.TabIndex = 97;
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(354, 55);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(111, 21);
            this.comboBoxDept.TabIndex = 96;
            // 
            // comboBoxDes
            // 
            this.comboBoxDes.DisplayMember = "DegName";
            this.comboBoxDes.FormattingEnabled = true;
            this.comboBoxDes.Location = new System.Drawing.Point(574, 55);
            this.comboBoxDes.Name = "comboBoxDes";
            this.comboBoxDes.Size = new System.Drawing.Size(123, 21);
            this.comboBoxDes.TabIndex = 95;
            this.comboBoxDes.ValueMember = "DegID";
            // 
            // lblEmpActive
            // 
            this.lblEmpActive.AutoSize = true;
            this.lblEmpActive.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpActive.Location = new System.Drawing.Point(753, 186);
            this.lblEmpActive.Name = "lblEmpActive";
            this.lblEmpActive.Size = new System.Drawing.Size(60, 14);
            this.lblEmpActive.TabIndex = 94;
            this.lblEmpActive.Text = "Active : ";
            // 
            // lblEmpDesignationID
            // 
            this.lblEmpDesignationID.AutoSize = true;
            this.lblEmpDesignationID.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpDesignationID.Location = new System.Drawing.Point(471, 58);
            this.lblEmpDesignationID.Name = "lblEmpDesignationID";
            this.lblEmpDesignationID.Size = new System.Drawing.Size(97, 14);
            this.lblEmpDesignationID.TabIndex = 93;
            this.lblEmpDesignationID.Text = "Designation : ";
            // 
            // lblEmpTermination
            // 
            this.lblEmpTermination.AutoSize = true;
            this.lblEmpTermination.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpTermination.Location = new System.Drawing.Point(571, 155);
            this.lblEmpTermination.Name = "lblEmpTermination";
            this.lblEmpTermination.Size = new System.Drawing.Size(132, 14);
            this.lblEmpTermination.TabIndex = 91;
            this.lblEmpTermination.Text = "Termination Date : ";
            // 
            // lblEmpAddress
            // 
            this.lblEmpAddress.AutoSize = true;
            this.lblEmpAddress.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpAddress.Location = new System.Drawing.Point(104, 186);
            this.lblEmpAddress.Name = "lblEmpAddress";
            this.lblEmpAddress.Size = new System.Drawing.Size(71, 14);
            this.lblEmpAddress.TabIndex = 90;
            this.lblEmpAddress.Text = "Address : ";
            // 
            // lblEmpEmail
            // 
            this.lblEmpEmail.AutoSize = true;
            this.lblEmpEmail.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpEmail.Location = new System.Drawing.Point(687, 123);
            this.lblEmpEmail.Name = "lblEmpEmail";
            this.lblEmpEmail.Size = new System.Drawing.Size(58, 14);
            this.lblEmpEmail.TabIndex = 89;
            this.lblEmpEmail.Text = "Email :  ";
            // 
            // lblEmpDOB
            // 
            this.lblEmpDOB.AutoSize = true;
            this.lblEmpDOB.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpDOB.Location = new System.Drawing.Point(317, 123);
            this.lblEmpDOB.Name = "lblEmpDOB";
            this.lblEmpDOB.Size = new System.Drawing.Size(103, 14);
            this.lblEmpDOB.TabIndex = 88;
            this.lblEmpDOB.Text = "Birth of Date : ";
            // 
            // lblEmpMaried
            // 
            this.lblEmpMaried.AutoSize = true;
            this.lblEmpMaried.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpMaried.Location = new System.Drawing.Point(703, 58);
            this.lblEmpMaried.Name = "lblEmpMaried";
            this.lblEmpMaried.Size = new System.Drawing.Size(110, 14);
            this.lblEmpMaried.TabIndex = 87;
            this.lblEmpMaried.Text = "Marital Status : ";
            // 
            // lblEmpGender
            // 
            this.lblEmpGender.AutoSize = true;
            this.lblEmpGender.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpGender.Location = new System.Drawing.Point(524, 90);
            this.lblEmpGender.Name = "lblEmpGender";
            this.lblEmpGender.Size = new System.Drawing.Size(69, 14);
            this.lblEmpGender.TabIndex = 86;
            this.lblEmpGender.Text = "Gender  : ";
            // 
            // lblEmpLastName
            // 
            this.lblEmpLastName.AutoSize = true;
            this.lblEmpLastName.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpLastName.Location = new System.Drawing.Point(317, 90);
            this.lblEmpLastName.Name = "lblEmpLastName";
            this.lblEmpLastName.Size = new System.Drawing.Size(87, 14);
            this.lblEmpLastName.TabIndex = 85;
            this.lblEmpLastName.Text = "Last Name : ";
            // 
            // lblEmpBlood
            // 
            this.lblEmpBlood.AutoSize = true;
            this.lblEmpBlood.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpBlood.Location = new System.Drawing.Point(104, 155);
            this.lblEmpBlood.Name = "lblEmpBlood";
            this.lblEmpBlood.Size = new System.Drawing.Size(98, 14);
            this.lblEmpBlood.TabIndex = 84;
            this.lblEmpBlood.Text = "Blood Group : ";
            // 
            // lblEmpJoin
            // 
            this.lblEmpJoin.AutoSize = true;
            this.lblEmpJoin.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpJoin.Location = new System.Drawing.Point(317, 155);
            this.lblEmpJoin.Name = "lblEmpJoin";
            this.lblEmpJoin.Size = new System.Drawing.Size(101, 14);
            this.lblEmpJoin.TabIndex = 83;
            this.lblEmpJoin.Text = "Joining Date : ";
            // 
            // lblEmpDepartID
            // 
            this.lblEmpDepartID.AutoSize = true;
            this.lblEmpDepartID.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpDepartID.Location = new System.Drawing.Point(251, 58);
            this.lblEmpDepartID.Name = "lblEmpDepartID";
            this.lblEmpDepartID.Size = new System.Drawing.Size(97, 14);
            this.lblEmpDepartID.TabIndex = 82;
            this.lblEmpDepartID.Text = "Department : ";
            // 
            // lblEmpCellPhone
            // 
            this.lblEmpCellPhone.AutoSize = true;
            this.lblEmpCellPhone.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpCellPhone.Location = new System.Drawing.Point(104, 123);
            this.lblEmpCellPhone.Name = "lblEmpCellPhone";
            this.lblEmpCellPhone.Size = new System.Drawing.Size(85, 14);
            this.lblEmpCellPhone.TabIndex = 81;
            this.lblEmpCellPhone.Text = "Cell Phone: ";
            // 
            // lblEmpFirstName
            // 
            this.lblEmpFirstName.AutoSize = true;
            this.lblEmpFirstName.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpFirstName.Location = new System.Drawing.Point(104, 90);
            this.lblEmpFirstName.Name = "lblEmpFirstName";
            this.lblEmpFirstName.Size = new System.Drawing.Size(90, 14);
            this.lblEmpFirstName.TabIndex = 80;
            this.lblEmpFirstName.Text = "First Name : ";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(107, 58);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(37, 14);
            this.lblEmpID.TabIndex = 116;
            this.lblEmpID.Text = "ID  : ";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(150, 55);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(95, 20);
            this.txtEmpID.TabIndex = 117;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDep.Location = new System.Drawing.Point(405, 15);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(273, 24);
            this.lblDep.TabIndex = 118;
            this.lblDep.Text = "Update Employee Information";
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.txtPicLocation);
            this.Controls.Add(this.comboBoxOperation);
            this.Controls.Add(this.checkBoxNo);
            this.Controls.Add(this.btnPicUpload);
            this.Controls.Add(this.btnSubmitEmployee);
            this.Controls.Add(this.DGVEmployee);
            this.Controls.Add(this.picEmployee);
            this.Controls.Add(this.txtEmpAddress);
            this.Controls.Add(this.checkboxYes);
            this.Controls.Add(this.dtpEmpTerDate);
            this.Controls.Add(this.dtpEmpJoinDate);
            this.Controls.Add(this.txtEmpBloodGroup);
            this.Controls.Add(this.txtEmpEmail);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtEmpPhone);
            this.Controls.Add(this.comboBoxMarital);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.txtEmpLastName);
            this.Controls.Add(this.txtEmpFirstName);
            this.Controls.Add(this.comboBoxDept);
            this.Controls.Add(this.comboBoxDes);
            this.Controls.Add(this.lblEmpActive);
            this.Controls.Add(this.lblEmpDesignationID);
            this.Controls.Add(this.lblEmpTermination);
            this.Controls.Add(this.lblEmpAddress);
            this.Controls.Add(this.lblEmpEmail);
            this.Controls.Add(this.lblEmpDOB);
            this.Controls.Add(this.lblEmpMaried);
            this.Controls.Add(this.lblEmpGender);
            this.Controls.Add(this.lblEmpLastName);
            this.Controls.Add(this.lblEmpBlood);
            this.Controls.Add(this.lblEmpJoin);
            this.Controls.Add(this.lblEmpDepartID);
            this.Controls.Add(this.lblEmpCellPhone);
            this.Controls.Add(this.lblEmpFirstName);
            this.Name = "UpdateEmployee";
            this.Size = new System.Drawing.Size(1140, 506);
            this.Load += new System.EventHandler(this.UpdateEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPicLocation;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.CheckBox checkBoxNo;
        private System.Windows.Forms.Button btnPicUpload;
        private System.Windows.Forms.Button btnSubmitEmployee;
        private System.Windows.Forms.DataGridView DGVEmployee;
        private System.Windows.Forms.PictureBox picEmployee;
        private System.Windows.Forms.TextBox txtEmpAddress;
        private System.Windows.Forms.CheckBox checkboxYes;
        private System.Windows.Forms.DateTimePicker dtpEmpTerDate;
        private System.Windows.Forms.DateTimePicker dtpEmpJoinDate;
        private System.Windows.Forms.TextBox txtEmpBloodGroup;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.ComboBox comboBoxMarital;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox txtEmpLastName;
        private System.Windows.Forms.TextBox txtEmpFirstName;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.ComboBox comboBoxDes;
        private System.Windows.Forms.Label lblEmpActive;
        private System.Windows.Forms.Label lblEmpDesignationID;
        private System.Windows.Forms.Label lblEmpTermination;
        private System.Windows.Forms.Label lblEmpAddress;
        private System.Windows.Forms.Label lblEmpEmail;
        private System.Windows.Forms.Label lblEmpDOB;
        private System.Windows.Forms.Label lblEmpMaried;
        private System.Windows.Forms.Label lblEmpGender;
        private System.Windows.Forms.Label lblEmpLastName;
        private System.Windows.Forms.Label lblEmpBlood;
        private System.Windows.Forms.Label lblEmpJoin;
        private System.Windows.Forms.Label lblEmpDepartID;
        private System.Windows.Forms.Label lblEmpCellPhone;
        private System.Windows.Forms.Label lblEmpFirstName;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lblDep;
    }
}
