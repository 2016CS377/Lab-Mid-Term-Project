namespace ProjectA
{
	partial class Manage_Students
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
			this.lblManageAll = new System.Windows.Forms.LinkLabel();
			this.lblExit = new System.Windows.Forms.LinkLabel();
			this.btnFemale = new System.Windows.Forms.RadioButton();
			this.btnMale = new System.Windows.Forms.RadioButton();
			this.btnAddStudent = new System.Windows.Forms.Button();
			this.txtRegNo = new System.Windows.Forms.TextBox();
			this.lblRegNo = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.txtDOB = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblDOB = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.txtContact = new System.Windows.Forms.TextBox();
			this.txtLName = new System.Windows.Forms.TextBox();
			this.txtFName = new System.Windows.Forms.TextBox();
			this.lblContact = new System.Windows.Forms.Label();
			this.lblLName = new System.Windows.Forms.Label();
			this.lblFName = new System.Windows.Forms.Label();
			this.btnUpdateStudent = new System.Windows.Forms.Button();
			this.btnDeleteStudent = new System.Windows.Forms.Button();
			this.lblExtractData = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// lblManageAll
			// 
			this.lblManageAll.AutoSize = true;
			this.lblManageAll.Location = new System.Drawing.Point(341, 417);
			this.lblManageAll.Name = "lblManageAll";
			this.lblManageAll.Size = new System.Drawing.Size(57, 13);
			this.lblManageAll.TabIndex = 37;
			this.lblManageAll.TabStop = true;
			this.lblManageAll.Text = "ManageAll";
			this.lblManageAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblManageAll_LinkClicked);
			// 
			// lblExit
			// 
			this.lblExit.AutoSize = true;
			this.lblExit.Location = new System.Drawing.Point(294, 417);
			this.lblExit.Name = "lblExit";
			this.lblExit.Size = new System.Drawing.Size(24, 13);
			this.lblExit.TabIndex = 36;
			this.lblExit.TabStop = true;
			this.lblExit.Text = "Exit";
			this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
			// 
			// btnFemale
			// 
			this.btnFemale.AutoSize = true;
			this.btnFemale.Location = new System.Drawing.Point(201, 335);
			this.btnFemale.Name = "btnFemale";
			this.btnFemale.Size = new System.Drawing.Size(59, 17);
			this.btnFemale.TabIndex = 35;
			this.btnFemale.TabStop = true;
			this.btnFemale.Text = "Female";
			this.btnFemale.UseVisualStyleBackColor = true;
			// 
			// btnMale
			// 
			this.btnMale.AutoSize = true;
			this.btnMale.Location = new System.Drawing.Point(201, 296);
			this.btnMale.Name = "btnMale";
			this.btnMale.Size = new System.Drawing.Size(48, 17);
			this.btnMale.TabIndex = 34;
			this.btnMale.TabStop = true;
			this.btnMale.Text = "Male";
			this.btnMale.UseVisualStyleBackColor = true;
			// 
			// btnAddStudent
			// 
			this.btnAddStudent.Location = new System.Drawing.Point(12, 372);
			this.btnAddStudent.Name = "btnAddStudent";
			this.btnAddStudent.Size = new System.Drawing.Size(82, 23);
			this.btnAddStudent.TabIndex = 33;
			this.btnAddStudent.Text = "Add Student";
			this.btnAddStudent.UseVisualStyleBackColor = true;
			this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
			// 
			// txtRegNo
			// 
			this.txtRegNo.Location = new System.Drawing.Point(201, 254);
			this.txtRegNo.Name = "txtRegNo";
			this.txtRegNo.Size = new System.Drawing.Size(100, 20);
			this.txtRegNo.TabIndex = 32;
			// 
			// lblRegNo
			// 
			this.lblRegNo.AutoSize = true;
			this.lblRegNo.Location = new System.Drawing.Point(62, 254);
			this.lblRegNo.Name = "lblRegNo";
			this.lblRegNo.Size = new System.Drawing.Size(77, 13);
			this.lblRegNo.TabIndex = 31;
			this.lblRegNo.Text = "RegistrationNo";
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Location = new System.Drawing.Point(60, 296);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(42, 13);
			this.lblGender.TabIndex = 30;
			this.lblGender.Text = "Gender";
			// 
			// txtDOB
			// 
			this.txtDOB.Location = new System.Drawing.Point(201, 208);
			this.txtDOB.Name = "txtDOB";
			this.txtDOB.Size = new System.Drawing.Size(100, 20);
			this.txtDOB.TabIndex = 29;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(201, 166);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(100, 20);
			this.txtEmail.TabIndex = 28;
			// 
			// lblDOB
			// 
			this.lblDOB.AutoSize = true;
			this.lblDOB.Location = new System.Drawing.Point(60, 208);
			this.lblDOB.Name = "lblDOB";
			this.lblDOB.Size = new System.Drawing.Size(62, 13);
			this.lblDOB.TabIndex = 27;
			this.lblDOB.Text = "DateOfBirth";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(62, 166);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(32, 13);
			this.lblEmail.TabIndex = 26;
			this.lblEmail.Text = "Email";
			// 
			// txtContact
			// 
			this.txtContact.Location = new System.Drawing.Point(201, 122);
			this.txtContact.Name = "txtContact";
			this.txtContact.Size = new System.Drawing.Size(100, 20);
			this.txtContact.TabIndex = 25;
			// 
			// txtLName
			// 
			this.txtLName.Location = new System.Drawing.Point(201, 83);
			this.txtLName.Name = "txtLName";
			this.txtLName.Size = new System.Drawing.Size(100, 20);
			this.txtLName.TabIndex = 24;
			// 
			// txtFName
			// 
			this.txtFName.Location = new System.Drawing.Point(201, 43);
			this.txtFName.Name = "txtFName";
			this.txtFName.Size = new System.Drawing.Size(100, 20);
			this.txtFName.TabIndex = 23;
			// 
			// lblContact
			// 
			this.lblContact.AutoSize = true;
			this.lblContact.Location = new System.Drawing.Point(60, 122);
			this.lblContact.Name = "lblContact";
			this.lblContact.Size = new System.Drawing.Size(44, 13);
			this.lblContact.TabIndex = 22;
			this.lblContact.Text = "Contact";
			// 
			// lblLName
			// 
			this.lblLName.AutoSize = true;
			this.lblLName.Location = new System.Drawing.Point(60, 83);
			this.lblLName.Name = "lblLName";
			this.lblLName.Size = new System.Drawing.Size(55, 13);
			this.lblLName.TabIndex = 21;
			this.lblLName.Text = "LastName";
			// 
			// lblFName
			// 
			this.lblFName.AutoSize = true;
			this.lblFName.Location = new System.Drawing.Point(60, 43);
			this.lblFName.Name = "lblFName";
			this.lblFName.Size = new System.Drawing.Size(54, 13);
			this.lblFName.TabIndex = 20;
			this.lblFName.Text = "FirstName";
			// 
			// btnUpdateStudent
			// 
			this.btnUpdateStudent.Location = new System.Drawing.Point(153, 372);
			this.btnUpdateStudent.Name = "btnUpdateStudent";
			this.btnUpdateStudent.Size = new System.Drawing.Size(82, 23);
			this.btnUpdateStudent.TabIndex = 38;
			this.btnUpdateStudent.Text = "Update Student";
			this.btnUpdateStudent.UseVisualStyleBackColor = true;
			this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
			// 
			// btnDeleteStudent
			// 
			this.btnDeleteStudent.Location = new System.Drawing.Point(316, 372);
			this.btnDeleteStudent.Name = "btnDeleteStudent";
			this.btnDeleteStudent.Size = new System.Drawing.Size(82, 23);
			this.btnDeleteStudent.TabIndex = 39;
			this.btnDeleteStudent.Text = "Delete Student";
			this.btnDeleteStudent.UseVisualStyleBackColor = true;
			this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
			// 
			// lblExtractData
			// 
			this.lblExtractData.Location = new System.Drawing.Point(95, 412);
			this.lblExtractData.Name = "lblExtractData";
			this.lblExtractData.Size = new System.Drawing.Size(172, 38);
			this.lblExtractData.TabIndex = 40;
			this.lblExtractData.Text = "Extract Data Through Registration No ";
			this.lblExtractData.UseVisualStyleBackColor = true;
			this.lblExtractData.Click += new System.EventHandler(this.lblExtractData_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(-2, -1);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(464, 38);
			this.richTextBox1.TabIndex = 45;
			this.richTextBox1.Text = "Note:Write  RegistrationNo correctly first for extacting data then UPDATE or DELE" +
    "TE";
			// 
			// Manage_Students
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 450);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.lblExtractData);
			this.Controls.Add(this.btnDeleteStudent);
			this.Controls.Add(this.btnUpdateStudent);
			this.Controls.Add(this.lblManageAll);
			this.Controls.Add(this.lblExit);
			this.Controls.Add(this.btnFemale);
			this.Controls.Add(this.btnMale);
			this.Controls.Add(this.btnAddStudent);
			this.Controls.Add(this.txtRegNo);
			this.Controls.Add(this.lblRegNo);
			this.Controls.Add(this.lblGender);
			this.Controls.Add(this.txtDOB);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lblDOB);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.txtContact);
			this.Controls.Add(this.txtLName);
			this.Controls.Add(this.txtFName);
			this.Controls.Add(this.lblContact);
			this.Controls.Add(this.lblLName);
			this.Controls.Add(this.lblFName);
			this.Name = "Manage_Students";
			this.Text = "Manage_Students";
			this.Load += new System.EventHandler(this.Manage_Students_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel lblManageAll;
		private System.Windows.Forms.LinkLabel lblExit;
		private System.Windows.Forms.RadioButton btnFemale;
		private System.Windows.Forms.RadioButton btnMale;
		private System.Windows.Forms.Button btnAddStudent;
		private System.Windows.Forms.TextBox txtRegNo;
		private System.Windows.Forms.Label lblRegNo;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.TextBox txtDOB;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label lblDOB;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox txtContact;
		private System.Windows.Forms.TextBox txtLName;
		private System.Windows.Forms.TextBox txtFName;
		private System.Windows.Forms.Label lblContact;
		private System.Windows.Forms.Label lblLName;
		private System.Windows.Forms.Label lblFName;
		private System.Windows.Forms.Button btnUpdateStudent;
		private System.Windows.Forms.Button btnDeleteStudent;
		private System.Windows.Forms.Button lblExtractData;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}