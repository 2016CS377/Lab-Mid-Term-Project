namespace ProjectA
{
	partial class Manage_Project
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.btnDeleteProject = new System.Windows.Forms.Button();
			this.btnUpdateProject = new System.Windows.Forms.Button();
			this.btnAddProject = new System.Windows.Forms.Button();
			this.lblAssignProject = new System.Windows.Forms.LinkLabel();
			this.lblManageAll = new System.Windows.Forms.LinkLabel();
			this.lblExit = new System.Windows.Forms.LinkLabel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lblListofProjects = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(36, 61);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(27, 13);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Title";
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(36, 118);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(60, 13);
			this.lblDescription.TabIndex = 1;
			this.lblDescription.Text = "Description";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(184, 61);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(100, 20);
			this.txtTitle.TabIndex = 2;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(184, 111);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(100, 20);
			this.txtDescription.TabIndex = 3;
			// 
			// btnDeleteProject
			// 
			this.btnDeleteProject.Location = new System.Drawing.Point(259, 160);
			this.btnDeleteProject.Name = "btnDeleteProject";
			this.btnDeleteProject.Size = new System.Drawing.Size(75, 34);
			this.btnDeleteProject.TabIndex = 13;
			this.btnDeleteProject.Text = "Delete Project";
			this.btnDeleteProject.UseVisualStyleBackColor = true;
			this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
			// 
			// btnUpdateProject
			// 
			this.btnUpdateProject.Location = new System.Drawing.Point(148, 157);
			this.btnUpdateProject.Name = "btnUpdateProject";
			this.btnUpdateProject.Size = new System.Drawing.Size(75, 37);
			this.btnUpdateProject.TabIndex = 12;
			this.btnUpdateProject.Text = "Update Project";
			this.btnUpdateProject.UseVisualStyleBackColor = true;
			this.btnUpdateProject.Click += new System.EventHandler(this.btnUpdateProject_Click);
			// 
			// btnAddProject
			// 
			this.btnAddProject.Location = new System.Drawing.Point(40, 157);
			this.btnAddProject.Name = "btnAddProject";
			this.btnAddProject.Size = new System.Drawing.Size(68, 37);
			this.btnAddProject.TabIndex = 11;
			this.btnAddProject.Text = "Add Project";
			this.btnAddProject.UseVisualStyleBackColor = true;
			this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
			// 
			// lblAssignProject
			// 
			this.lblAssignProject.AutoSize = true;
			this.lblAssignProject.Location = new System.Drawing.Point(260, 424);
			this.lblAssignProject.Name = "lblAssignProject";
			this.lblAssignProject.Size = new System.Drawing.Size(74, 13);
			this.lblAssignProject.TabIndex = 14;
			this.lblAssignProject.TabStop = true;
			this.lblAssignProject.Text = "Assign Project";
			this.lblAssignProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAssignProject_LinkClicked);
			// 
			// lblManageAll
			// 
			this.lblManageAll.AutoSize = true;
			this.lblManageAll.Location = new System.Drawing.Point(98, 424);
			this.lblManageAll.Name = "lblManageAll";
			this.lblManageAll.Size = new System.Drawing.Size(57, 13);
			this.lblManageAll.TabIndex = 16;
			this.lblManageAll.TabStop = true;
			this.lblManageAll.Text = "ManageAll";
			this.lblManageAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblManageAll_LinkClicked);
			// 
			// lblExit
			// 
			this.lblExit.AutoSize = true;
			this.lblExit.Location = new System.Drawing.Point(36, 424);
			this.lblExit.Name = "lblExit";
			this.lblExit.Size = new System.Drawing.Size(24, 13);
			this.lblExit.TabIndex = 15;
			this.lblExit.TabStop = true;
			this.lblExit.Text = "Exit";
			this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 253);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(383, 150);
			this.dataGridView1.TabIndex = 45;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// lblListofProjects
			// 
			this.lblListofProjects.AutoSize = true;
			this.lblListofProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblListofProjects.Location = new System.Drawing.Point(8, 201);
			this.lblListofProjects.Name = "lblListofProjects";
			this.lblListofProjects.Size = new System.Drawing.Size(116, 20);
			this.lblListofProjects.TabIndex = 44;
			this.lblListofProjects.Text = "List of projects:";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(-2, 1);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(397, 54);
			this.richTextBox1.TabIndex = 46;
			this.richTextBox1.Text = "Note:Click on the row from GridView for Extracting data then UPDATE Oor DELETE";
			// 
			// Manage_Project
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 446);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.lblListofProjects);
			this.Controls.Add(this.lblManageAll);
			this.Controls.Add(this.lblExit);
			this.Controls.Add(this.lblAssignProject);
			this.Controls.Add(this.btnDeleteProject);
			this.Controls.Add(this.btnUpdateProject);
			this.Controls.Add(this.btnAddProject);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.lblTitle);
			this.Name = "Manage_Project";
			this.Text = "Manage_Project";
			this.Load += new System.EventHandler(this.Manage_Project_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Button btnDeleteProject;
		private System.Windows.Forms.Button btnUpdateProject;
		private System.Windows.Forms.Button btnAddProject;
		private System.Windows.Forms.LinkLabel lblAssignProject;
		private System.Windows.Forms.LinkLabel lblManageAll;
		private System.Windows.Forms.LinkLabel lblExit;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label lblListofProjects;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}