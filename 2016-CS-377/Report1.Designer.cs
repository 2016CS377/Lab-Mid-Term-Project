namespace ProjectA
{
	partial class Report1
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.btnReport1 = new System.Windows.Forms.Button();
			this.btnReport2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblExit = new System.Windows.Forms.LinkLabel();
			this.lblManageAll = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 101);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(417, 232);
			this.dataGridView1.TabIndex = 0;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(435, 101);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(353, 232);
			this.dataGridView2.TabIndex = 1;
			// 
			// btnReport1
			// 
			this.btnReport1.Location = new System.Drawing.Point(156, 373);
			this.btnReport1.Name = "btnReport1";
			this.btnReport1.Size = new System.Drawing.Size(133, 23);
			this.btnReport1.TabIndex = 2;
			this.btnReport1.Text = "Generate Report1";
			this.btnReport1.UseVisualStyleBackColor = true;
			this.btnReport1.Click += new System.EventHandler(this.btnReport1_Click);
			// 
			// btnReport2
			// 
			this.btnReport2.Location = new System.Drawing.Point(557, 373);
			this.btnReport2.Name = "btnReport2";
			this.btnReport2.Size = new System.Drawing.Size(108, 23);
			this.btnReport2.TabIndex = 3;
			this.btnReport2.Text = "Generate Report2";
			this.btnReport2.UseVisualStyleBackColor = true;
			this.btnReport2.Click += new System.EventHandler(this.btnReport2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(5, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(428, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "List of projects along with advisory board and list of students:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(432, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(173, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Marks sheet of projects:";
			// 
			// lblExit
			// 
			this.lblExit.AutoSize = true;
			this.lblExit.Location = new System.Drawing.Point(22, 405);
			this.lblExit.Name = "lblExit";
			this.lblExit.Size = new System.Drawing.Size(24, 13);
			this.lblExit.TabIndex = 6;
			this.lblExit.TabStop = true;
			this.lblExit.Text = "Exit";
			this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
			// 
			// lblManageAll
			// 
			this.lblManageAll.AutoSize = true;
			this.lblManageAll.Location = new System.Drawing.Point(728, 405);
			this.lblManageAll.Name = "lblManageAll";
			this.lblManageAll.Size = new System.Drawing.Size(60, 13);
			this.lblManageAll.TabIndex = 7;
			this.lblManageAll.TabStop = true;
			this.lblManageAll.Text = "Manage All";
			this.lblManageAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblManageAll_LinkClicked);
			// 
			// Report1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblManageAll);
			this.Controls.Add(this.lblExit);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnReport2);
			this.Controls.Add(this.btnReport1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Report1";
			this.Text = "Report1";
			this.Load += new System.EventHandler(this.Report1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Button btnReport1;
		private System.Windows.Forms.Button btnReport2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel lblExit;
		private System.Windows.Forms.LinkLabel lblManageAll;
	}
}