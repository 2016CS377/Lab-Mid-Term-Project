namespace ProjectA
{
	partial class Group_Students
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblAssignmentDate = new System.Windows.Forms.Label();
			this.lblstatus = new System.Windows.Forms.Label();
			this.txtAssignmentDate = new System.Windows.Forms.TextBox();
			this.btnGroupStudents = new System.Windows.Forms.Button();
			this.lblAssignProject = new System.Windows.Forms.LinkLabel();
			this.lblManageAll = new System.Windows.Forms.LinkLabel();
			this.lblExit = new System.Windows.Forms.LinkLabel();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cbStatus = new System.Windows.Forms.ComboBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "List of All Students:";
			// 
			// lblAssignmentDate
			// 
			this.lblAssignmentDate.AutoSize = true;
			this.lblAssignmentDate.Location = new System.Drawing.Point(37, 257);
			this.lblAssignmentDate.Name = "lblAssignmentDate";
			this.lblAssignmentDate.Size = new System.Drawing.Size(87, 13);
			this.lblAssignmentDate.TabIndex = 2;
			this.lblAssignmentDate.Text = "Assignment Date";
			// 
			// lblstatus
			// 
			this.lblstatus.AutoSize = true;
			this.lblstatus.Location = new System.Drawing.Point(37, 300);
			this.lblstatus.Name = "lblstatus";
			this.lblstatus.Size = new System.Drawing.Size(37, 13);
			this.lblstatus.TabIndex = 3;
			this.lblstatus.Text = "Status";
			// 
			// txtAssignmentDate
			// 
			this.txtAssignmentDate.Location = new System.Drawing.Point(143, 250);
			this.txtAssignmentDate.Name = "txtAssignmentDate";
			this.txtAssignmentDate.Size = new System.Drawing.Size(121, 20);
			this.txtAssignmentDate.TabIndex = 4;
			// 
			// btnGroupStudents
			// 
			this.btnGroupStudents.Location = new System.Drawing.Point(58, 358);
			this.btnGroupStudents.Name = "btnGroupStudents";
			this.btnGroupStudents.Size = new System.Drawing.Size(100, 23);
			this.btnGroupStudents.TabIndex = 6;
			this.btnGroupStudents.Text = "Group Students";
			this.btnGroupStudents.UseVisualStyleBackColor = true;
			this.btnGroupStudents.Click += new System.EventHandler(this.btnGroupStudents_Click);
			// 
			// lblAssignProject
			// 
			this.lblAssignProject.AutoSize = true;
			this.lblAssignProject.Location = new System.Drawing.Point(292, 368);
			this.lblAssignProject.Name = "lblAssignProject";
			this.lblAssignProject.Size = new System.Drawing.Size(74, 13);
			this.lblAssignProject.TabIndex = 8;
			this.lblAssignProject.TabStop = true;
			this.lblAssignProject.Text = "Assign Project";
			this.lblAssignProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAssignProject_LinkClicked);
			// 
			// lblManageAll
			// 
			this.lblManageAll.AutoSize = true;
			this.lblManageAll.Location = new System.Drawing.Point(292, 410);
			this.lblManageAll.Name = "lblManageAll";
			this.lblManageAll.Size = new System.Drawing.Size(57, 13);
			this.lblManageAll.TabIndex = 42;
			this.lblManageAll.TabStop = true;
			this.lblManageAll.Text = "ManageAll";
			this.lblManageAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblManageAll_LinkClicked);
			// 
			// lblExit
			// 
			this.lblExit.AutoSize = true;
			this.lblExit.Location = new System.Drawing.Point(379, 410);
			this.lblExit.Name = "lblExit";
			this.lblExit.Size = new System.Drawing.Size(24, 13);
			this.lblExit.TabIndex = 41;
			this.lblExit.TabStop = true;
			this.lblExit.Text = "Exit";
			this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(40, 91);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(127, 134);
			this.listBox1.TabIndex = 43;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(276, 91);
			this.listBox2.Name = "listBox2";
			this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBox2.Size = new System.Drawing.Size(127, 134);
			this.listBox2.TabIndex = 44;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(173, 128);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 69);
			this.button1.TabIndex = 45;
			this.button1.Text = "Select and Add Students To Make Group";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(265, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(218, 20);
			this.label2.TabIndex = 46;
			this.label2.Text = "List of Students for Grouping:";
			// 
			// cbStatus
			// 
			this.cbStatus.FormattingEnabled = true;
			this.cbStatus.Items.AddRange(new object[] {
            "Active",
            "InActive"});
			this.cbStatus.Location = new System.Drawing.Point(143, 292);
			this.cbStatus.Name = "cbStatus";
			this.cbStatus.Size = new System.Drawing.Size(121, 21);
			this.cbStatus.TabIndex = 47;
			this.cbStatus.Text = "---Select Item---";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(-4, 8);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(498, 46);
			this.richTextBox1.TabIndex = 48;
			this.richTextBox1.Text = "Note:Select from all students list and add in the grouping list then select all a" +
    "nd make group";
			// 
			// Group_Students
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 450);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.cbStatus);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.lblManageAll);
			this.Controls.Add(this.lblExit);
			this.Controls.Add(this.lblAssignProject);
			this.Controls.Add(this.btnGroupStudents);
			this.Controls.Add(this.txtAssignmentDate);
			this.Controls.Add(this.lblstatus);
			this.Controls.Add(this.lblAssignmentDate);
			this.Controls.Add(this.label1);
			this.Name = "Group_Students";
			this.Text = "Group_Students";
			this.Load += new System.EventHandler(this.Group_Students_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblAssignmentDate;
		private System.Windows.Forms.Label lblstatus;
		private System.Windows.Forms.TextBox txtAssignmentDate;
		private System.Windows.Forms.Button btnGroupStudents;
		private System.Windows.Forms.LinkLabel lblAssignProject;
		private System.Windows.Forms.LinkLabel lblManageAll;
		private System.Windows.Forms.LinkLabel lblExit;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbStatus;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}