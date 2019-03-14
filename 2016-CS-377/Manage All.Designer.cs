namespace ProjectA
{
	partial class Manage_All
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
			this.btnManageStudents = new System.Windows.Forms.Button();
			this.btnManageAdvisors = new System.Windows.Forms.Button();
			this.btnManageEvaluation = new System.Windows.Forms.Button();
			this.btnManageProjects = new System.Windows.Forms.Button();
			this.btnManageGroups = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnReports = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnManageStudents
			// 
			this.btnManageStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnManageStudents.Location = new System.Drawing.Point(50, 110);
			this.btnManageStudents.Name = "btnManageStudents";
			this.btnManageStudents.Size = new System.Drawing.Size(230, 85);
			this.btnManageStudents.TabIndex = 0;
			this.btnManageStudents.Text = "Manage Students";
			this.btnManageStudents.UseVisualStyleBackColor = true;
			this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
			// 
			// btnManageAdvisors
			// 
			this.btnManageAdvisors.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnManageAdvisors.Location = new System.Drawing.Point(375, 110);
			this.btnManageAdvisors.Name = "btnManageAdvisors";
			this.btnManageAdvisors.Size = new System.Drawing.Size(248, 85);
			this.btnManageAdvisors.TabIndex = 1;
			this.btnManageAdvisors.Text = "Manage Advisors";
			this.btnManageAdvisors.UseVisualStyleBackColor = true;
			this.btnManageAdvisors.Click += new System.EventHandler(this.btnManageAdvisors_Click_1);
			// 
			// btnManageEvaluation
			// 
			this.btnManageEvaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnManageEvaluation.Location = new System.Drawing.Point(50, 229);
			this.btnManageEvaluation.Name = "btnManageEvaluation";
			this.btnManageEvaluation.Size = new System.Drawing.Size(230, 84);
			this.btnManageEvaluation.TabIndex = 2;
			this.btnManageEvaluation.Text = "Manage Evaluation";
			this.btnManageEvaluation.UseVisualStyleBackColor = true;
			this.btnManageEvaluation.Click += new System.EventHandler(this.btnManageEvaluation_Click);
			// 
			// btnManageProjects
			// 
			this.btnManageProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnManageProjects.Location = new System.Drawing.Point(50, 356);
			this.btnManageProjects.Name = "btnManageProjects";
			this.btnManageProjects.Size = new System.Drawing.Size(230, 86);
			this.btnManageProjects.TabIndex = 3;
			this.btnManageProjects.Text = "Manage Projects";
			this.btnManageProjects.UseVisualStyleBackColor = true;
			this.btnManageProjects.Click += new System.EventHandler(this.btnManageProjects_Click);
			// 
			// btnManageGroups
			// 
			this.btnManageGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnManageGroups.Location = new System.Drawing.Point(371, 356);
			this.btnManageGroups.Name = "btnManageGroups";
			this.btnManageGroups.Size = new System.Drawing.Size(252, 86);
			this.btnManageGroups.TabIndex = 4;
			this.btnManageGroups.Text = "Manage Groups";
			this.btnManageGroups.UseVisualStyleBackColor = true;
			this.btnManageGroups.Click += new System.EventHandler(this.btnManageGroups_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(189, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(294, 33);
			this.label1.TabIndex = 5;
			this.label1.Text = "What you wnat to do?";
			// 
			// btnReports
			// 
			this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReports.Location = new System.Drawing.Point(375, 229);
			this.btnReports.Name = "btnReports";
			this.btnReports.Size = new System.Drawing.Size(248, 84);
			this.btnReports.TabIndex = 6;
			this.btnReports.Text = "Reports";
			this.btnReports.UseVisualStyleBackColor = true;
			this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
			// 
			// Manage_All
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 500);
			this.Controls.Add(this.btnReports);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnManageGroups);
			this.Controls.Add(this.btnManageProjects);
			this.Controls.Add(this.btnManageEvaluation);
			this.Controls.Add(this.btnManageAdvisors);
			this.Controls.Add(this.btnManageStudents);
			this.Name = "Manage_All";
			this.Text = "Manage_All";
			this.Load += new System.EventHandler(this.Manage_All_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnManageStudents;
		private System.Windows.Forms.Button btnManageAdvisors;
		private System.Windows.Forms.Button btnManageEvaluation;
		private System.Windows.Forms.Button btnManageProjects;
		private System.Windows.Forms.Button btnManageGroups;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnReports;
	}
}