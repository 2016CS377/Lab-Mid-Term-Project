namespace ProjectA
{
	partial class Group_Project
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
			this.txtAssignmentDate = new System.Windows.Forms.TextBox();
			this.lblAssignmentDate = new System.Windows.Forms.Label();
			this.lblListofProjects = new System.Windows.Forms.Label();
			this.btnAssignProject = new System.Windows.Forms.Button();
			this.lblManageAll = new System.Windows.Forms.LinkLabel();
			this.lblExit = new System.Windows.Forms.LinkLabel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbTitle = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtAssignmentDate
			// 
			this.txtAssignmentDate.Location = new System.Drawing.Point(230, 77);
			this.txtAssignmentDate.Name = "txtAssignmentDate";
			this.txtAssignmentDate.Size = new System.Drawing.Size(194, 20);
			this.txtAssignmentDate.TabIndex = 1;
			// 
			// lblAssignmentDate
			// 
			this.lblAssignmentDate.AutoSize = true;
			this.lblAssignmentDate.Location = new System.Drawing.Point(38, 77);
			this.lblAssignmentDate.Name = "lblAssignmentDate";
			this.lblAssignmentDate.Size = new System.Drawing.Size(87, 13);
			this.lblAssignmentDate.TabIndex = 2;
			this.lblAssignmentDate.Text = "Assignment Date";
			// 
			// lblListofProjects
			// 
			this.lblListofProjects.AutoSize = true;
			this.lblListofProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblListofProjects.Location = new System.Drawing.Point(37, 145);
			this.lblListofProjects.Name = "lblListofProjects";
			this.lblListofProjects.Size = new System.Drawing.Size(116, 20);
			this.lblListofProjects.TabIndex = 3;
			this.lblListofProjects.Text = "List of projects:";
			// 
			// btnAssignProject
			// 
			this.btnAssignProject.Location = new System.Drawing.Point(121, 363);
			this.btnAssignProject.Name = "btnAssignProject";
			this.btnAssignProject.Size = new System.Drawing.Size(143, 23);
			this.btnAssignProject.TabIndex = 4;
			this.btnAssignProject.Text = "Assign Project";
			this.btnAssignProject.UseVisualStyleBackColor = true;
			this.btnAssignProject.Click += new System.EventHandler(this.btnAssignProject_Click);
			// 
			// lblManageAll
			// 
			this.lblManageAll.AutoSize = true;
			this.lblManageAll.Location = new System.Drawing.Point(313, 400);
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
			this.lblExit.Location = new System.Drawing.Point(400, 400);
			this.lblExit.Name = "lblExit";
			this.lblExit.Size = new System.Drawing.Size(24, 13);
			this.lblExit.TabIndex = 41;
			this.lblExit.TabStop = true;
			this.lblExit.Text = "Exit";
			this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(41, 194);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(383, 150);
			this.dataGridView1.TabIndex = 43;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(-2, -1);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(468, 48);
			this.richTextBox1.TabIndex = 46;
			this.richTextBox1.Text = "Note:Select Project from GridView for the assignment of a project to a group";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 13);
			this.label1.TabIndex = 44;
			this.label1.Text = "Select Project Title";
			// 
			// cbTitle
			// 
			this.cbTitle.FormattingEnabled = true;
			this.cbTitle.Location = new System.Drawing.Point(230, 115);
			this.cbTitle.Name = "cbTitle";
			this.cbTitle.Size = new System.Drawing.Size(194, 21);
			this.cbTitle.TabIndex = 45;
			// 
			// Group_Project
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 450);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.cbTitle);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.lblManageAll);
			this.Controls.Add(this.lblExit);
			this.Controls.Add(this.btnAssignProject);
			this.Controls.Add(this.lblListofProjects);
			this.Controls.Add(this.lblAssignmentDate);
			this.Controls.Add(this.txtAssignmentDate);
			this.Name = "Group_Project";
			this.Text = "Group_Project";
			this.Load += new System.EventHandler(this.Group_Project_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtAssignmentDate;
		private System.Windows.Forms.Label lblAssignmentDate;
		private System.Windows.Forms.Label lblListofProjects;
		private System.Windows.Forms.Button btnAssignProject;
		private System.Windows.Forms.LinkLabel lblManageAll;
		private System.Windows.Forms.LinkLabel lblExit;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbTitle;
	}
}