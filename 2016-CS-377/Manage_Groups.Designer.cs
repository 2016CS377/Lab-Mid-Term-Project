namespace ProjectA
{
	partial class Manage_Groups
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
			this.btnCreateGroup = new System.Windows.Forms.Button();
			this.lblCreatedOn = new System.Windows.Forms.Label();
			this.txtCreatedOn = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.lblGroupStudents = new System.Windows.Forms.LinkLabel();
			this.lblManageAll = new System.Windows.Forms.LinkLabel();
			this.lblExit = new System.Windows.Forms.LinkLabel();
			this.lblExtractData = new System.Windows.Forms.Button();
			this.btnDeleteAdvisor = new System.Windows.Forms.Button();
			this.btnUpdateGroup = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCreateGroup
			// 
			this.btnCreateGroup.Location = new System.Drawing.Point(12, 81);
			this.btnCreateGroup.Name = "btnCreateGroup";
			this.btnCreateGroup.Size = new System.Drawing.Size(86, 23);
			this.btnCreateGroup.TabIndex = 0;
			this.btnCreateGroup.Text = "Create Group";
			this.btnCreateGroup.UseVisualStyleBackColor = true;
			this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
			// 
			// lblCreatedOn
			// 
			this.lblCreatedOn.AutoSize = true;
			this.lblCreatedOn.Location = new System.Drawing.Point(37, 50);
			this.lblCreatedOn.Name = "lblCreatedOn";
			this.lblCreatedOn.Size = new System.Drawing.Size(61, 13);
			this.lblCreatedOn.TabIndex = 1;
			this.lblCreatedOn.Text = "Created On";
			// 
			// txtCreatedOn
			// 
			this.txtCreatedOn.Location = new System.Drawing.Point(180, 43);
			this.txtCreatedOn.Name = "txtCreatedOn";
			this.txtCreatedOn.Size = new System.Drawing.Size(100, 20);
			this.txtCreatedOn.TabIndex = 2;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(40, 147);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(341, 150);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(39, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "List of groups:";
			// 
			// lblGroupStudents
			// 
			this.lblGroupStudents.AutoSize = true;
			this.lblGroupStudents.Location = new System.Drawing.Point(300, 334);
			this.lblGroupStudents.Name = "lblGroupStudents";
			this.lblGroupStudents.Size = new System.Drawing.Size(81, 13);
			this.lblGroupStudents.TabIndex = 5;
			this.lblGroupStudents.TabStop = true;
			this.lblGroupStudents.Text = "Group Students";
			this.lblGroupStudents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGroupStudents_LinkClicked);
			// 
			// lblManageAll
			// 
			this.lblManageAll.AutoSize = true;
			this.lblManageAll.Location = new System.Drawing.Point(76, 334);
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
			this.lblExit.Location = new System.Drawing.Point(37, 334);
			this.lblExit.Name = "lblExit";
			this.lblExit.Size = new System.Drawing.Size(24, 13);
			this.lblExit.TabIndex = 7;
			this.lblExit.TabStop = true;
			this.lblExit.Text = "Exit";
			this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
			// 
			// lblExtractData
			// 
			this.lblExtractData.Location = new System.Drawing.Point(286, 76);
			this.lblExtractData.Name = "lblExtractData";
			this.lblExtractData.Size = new System.Drawing.Size(172, 35);
			this.lblExtractData.TabIndex = 47;
			this.lblExtractData.Text = "Extract Data Through Registration No ";
			this.lblExtractData.UseVisualStyleBackColor = true;
			// 
			// btnDeleteAdvisor
			// 
			this.btnDeleteAdvisor.Location = new System.Drawing.Point(198, 81);
			this.btnDeleteAdvisor.Name = "btnDeleteAdvisor";
			this.btnDeleteAdvisor.Size = new System.Drawing.Size(82, 23);
			this.btnDeleteAdvisor.TabIndex = 46;
			this.btnDeleteAdvisor.Text = "Delete Student";
			this.btnDeleteAdvisor.UseVisualStyleBackColor = true;
			this.btnDeleteAdvisor.Click += new System.EventHandler(this.btnDeleteAdvisor_Click);
			// 
			// btnUpdateGroup
			// 
			this.btnUpdateGroup.Location = new System.Drawing.Point(110, 81);
			this.btnUpdateGroup.Name = "btnUpdateGroup";
			this.btnUpdateGroup.Size = new System.Drawing.Size(82, 23);
			this.btnUpdateGroup.TabIndex = 45;
			this.btnUpdateGroup.Text = "Update ";
			this.btnUpdateGroup.UseVisualStyleBackColor = true;
			this.btnUpdateGroup.Click += new System.EventHandler(this.btnUpdateGroup_Click_1);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(-2, 2);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(460, 35);
			this.richTextBox1.TabIndex = 48;
			this.richTextBox1.Text = "Note:Click on the row from GridView for Extracting data then UPDATE Oor DELETE";
			// 
			// Manage_Groups
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 356);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.lblExtractData);
			this.Controls.Add(this.btnDeleteAdvisor);
			this.Controls.Add(this.btnUpdateGroup);
			this.Controls.Add(this.lblManageAll);
			this.Controls.Add(this.lblExit);
			this.Controls.Add(this.lblGroupStudents);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtCreatedOn);
			this.Controls.Add(this.lblCreatedOn);
			this.Controls.Add(this.btnCreateGroup);
			this.Name = "Manage_Groups";
			this.Text = "Manage_Groups";
			this.Load += new System.EventHandler(this.Manage_Groups_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCreateGroup;
		private System.Windows.Forms.Label lblCreatedOn;
		private System.Windows.Forms.TextBox txtCreatedOn;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel lblGroupStudents;
		private System.Windows.Forms.LinkLabel lblManageAll;
		private System.Windows.Forms.LinkLabel lblExit;
		private System.Windows.Forms.Button lblExtractData;
		private System.Windows.Forms.Button btnDeleteAdvisor;
		private System.Windows.Forms.Button btnUpdateGroup;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}