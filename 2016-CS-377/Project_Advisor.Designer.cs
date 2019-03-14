namespace ProjectA
{
	partial class Project_Advisor
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
			this.cbAdvisorRole = new System.Windows.Forms.ComboBox();
			this.txtAssignmentDate = new System.Windows.Forms.TextBox();
			this.lblAdvisorRole = new System.Windows.Forms.Label();
			this.lblAssignmentDate = new System.Windows.Forms.Label();
			this.btnAssignProjectAdvisor = new System.Windows.Forms.Button();
			this.lblManageAll = new System.Windows.Forms.LinkLabel();
			this.lblExit = new System.Windows.Forms.LinkLabel();
			this.lblRegistrationNumber = new System.Windows.Forms.Label();
			this.txtRegistrationNo = new System.Windows.Forms.TextBox();
			this.cbDesignation = new System.Windows.Forms.ComboBox();
			this.lblDesignation = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cbAdvisorRole
			// 
			this.cbAdvisorRole.FormattingEnabled = true;
			this.cbAdvisorRole.Items.AddRange(new object[] {
            "Main Advisor",
            "Co-Advisror",
            "Industry Advisor"});
			this.cbAdvisorRole.Location = new System.Drawing.Point(252, 71);
			this.cbAdvisorRole.Name = "cbAdvisorRole";
			this.cbAdvisorRole.Size = new System.Drawing.Size(121, 21);
			this.cbAdvisorRole.TabIndex = 1;
			this.cbAdvisorRole.Text = "---Select Value---";
			// 
			// txtAssignmentDate
			// 
			this.txtAssignmentDate.Location = new System.Drawing.Point(252, 158);
			this.txtAssignmentDate.Name = "txtAssignmentDate";
			this.txtAssignmentDate.Size = new System.Drawing.Size(121, 20);
			this.txtAssignmentDate.TabIndex = 2;
			// 
			// lblAdvisorRole
			// 
			this.lblAdvisorRole.AutoSize = true;
			this.lblAdvisorRole.Location = new System.Drawing.Point(71, 79);
			this.lblAdvisorRole.Name = "lblAdvisorRole";
			this.lblAdvisorRole.Size = new System.Drawing.Size(67, 13);
			this.lblAdvisorRole.TabIndex = 3;
			this.lblAdvisorRole.Text = "Advisor Role";
			// 
			// lblAssignmentDate
			// 
			this.lblAssignmentDate.AutoSize = true;
			this.lblAssignmentDate.Location = new System.Drawing.Point(71, 165);
			this.lblAssignmentDate.Name = "lblAssignmentDate";
			this.lblAssignmentDate.Size = new System.Drawing.Size(87, 13);
			this.lblAssignmentDate.TabIndex = 4;
			this.lblAssignmentDate.Text = "Assignment Date";
			// 
			// btnAssignProjectAdvisor
			// 
			this.btnAssignProjectAdvisor.Location = new System.Drawing.Point(113, 263);
			this.btnAssignProjectAdvisor.Name = "btnAssignProjectAdvisor";
			this.btnAssignProjectAdvisor.Size = new System.Drawing.Size(146, 23);
			this.btnAssignProjectAdvisor.TabIndex = 5;
			this.btnAssignProjectAdvisor.Text = "Assign Project Advisor";
			this.btnAssignProjectAdvisor.UseVisualStyleBackColor = true;
			this.btnAssignProjectAdvisor.Click += new System.EventHandler(this.btnAssignProjectAdvisor_Click);
			// 
			// lblManageAll
			// 
			this.lblManageAll.AutoSize = true;
			this.lblManageAll.Location = new System.Drawing.Point(345, 313);
			this.lblManageAll.Name = "lblManageAll";
			this.lblManageAll.Size = new System.Drawing.Size(57, 13);
			this.lblManageAll.TabIndex = 8;
			this.lblManageAll.TabStop = true;
			this.lblManageAll.Text = "ManageAll";
			this.lblManageAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblManageAll_LinkClicked);
			// 
			// lblExit
			// 
			this.lblExit.AutoSize = true;
			this.lblExit.Location = new System.Drawing.Point(304, 313);
			this.lblExit.Name = "lblExit";
			this.lblExit.Size = new System.Drawing.Size(24, 13);
			this.lblExit.TabIndex = 7;
			this.lblExit.TabStop = true;
			this.lblExit.Text = "Exit";
			this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
			// 
			// lblRegistrationNumber
			// 
			this.lblRegistrationNumber.AutoSize = true;
			this.lblRegistrationNumber.Location = new System.Drawing.Point(71, 212);
			this.lblRegistrationNumber.Name = "lblRegistrationNumber";
			this.lblRegistrationNumber.Size = new System.Drawing.Size(103, 13);
			this.lblRegistrationNumber.TabIndex = 12;
			this.lblRegistrationNumber.Text = "Registration Number";
			// 
			// txtRegistrationNo
			// 
			this.txtRegistrationNo.Location = new System.Drawing.Point(252, 205);
			this.txtRegistrationNo.Name = "txtRegistrationNo";
			this.txtRegistrationNo.Size = new System.Drawing.Size(121, 20);
			this.txtRegistrationNo.TabIndex = 11;
			// 
			// cbDesignation
			// 
			this.cbDesignation.FormattingEnabled = true;
			this.cbDesignation.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assisstant Professor",
            "Lecturer",
            "Industry Professional"});
			this.cbDesignation.Location = new System.Drawing.Point(252, 111);
			this.cbDesignation.Name = "cbDesignation";
			this.cbDesignation.Size = new System.Drawing.Size(121, 21);
			this.cbDesignation.TabIndex = 40;
			this.cbDesignation.Text = "--Select Value--";
			// 
			// lblDesignation
			// 
			this.lblDesignation.AutoSize = true;
			this.lblDesignation.Location = new System.Drawing.Point(71, 119);
			this.lblDesignation.Name = "lblDesignation";
			this.lblDesignation.Size = new System.Drawing.Size(63, 13);
			this.lblDesignation.TabIndex = 39;
			this.lblDesignation.Text = "Designation";
			this.lblDesignation.Click += new System.EventHandler(this.lblDesignation_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 16);
			this.label1.TabIndex = 42;
			// 
			// Project_Advisor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 362);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbDesignation);
			this.Controls.Add(this.lblDesignation);
			this.Controls.Add(this.lblRegistrationNumber);
			this.Controls.Add(this.txtRegistrationNo);
			this.Controls.Add(this.lblManageAll);
			this.Controls.Add(this.lblExit);
			this.Controls.Add(this.btnAssignProjectAdvisor);
			this.Controls.Add(this.lblAssignmentDate);
			this.Controls.Add(this.lblAdvisorRole);
			this.Controls.Add(this.txtAssignmentDate);
			this.Controls.Add(this.cbAdvisorRole);
			this.Name = "Project_Advisor";
			this.Text = "Project_Advisor";
			this.Load += new System.EventHandler(this.Project_Advisor_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbAdvisorRole;
		private System.Windows.Forms.TextBox txtAssignmentDate;
		private System.Windows.Forms.Label lblAdvisorRole;
		private System.Windows.Forms.Label lblAssignmentDate;
		private System.Windows.Forms.Button btnAssignProjectAdvisor;
		private System.Windows.Forms.LinkLabel lblManageAll;
		private System.Windows.Forms.LinkLabel lblExit;
		private System.Windows.Forms.Label lblRegistrationNumber;
		private System.Windows.Forms.TextBox txtRegistrationNo;
		private System.Windows.Forms.ComboBox cbDesignation;
		private System.Windows.Forms.Label lblDesignation;
		private System.Windows.Forms.Label label1;
	}
}