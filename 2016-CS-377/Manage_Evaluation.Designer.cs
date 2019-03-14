namespace ProjectA
{
	partial class Manage_Evaluation
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
			this.lblNameEvaluation = new System.Windows.Forms.Label();
			this.lblTotalMarks = new System.Windows.Forms.Label();
			this.lblTotalWeightage = new System.Windows.Forms.Label();
			this.txtNameEvaluation = new System.Windows.Forms.TextBox();
			this.txtTotalMarks = new System.Windows.Forms.TextBox();
			this.txtTotalWeightage = new System.Windows.Forms.TextBox();
			this.btnAddEvaluation = new System.Windows.Forms.Button();
			this.btnUpdateEvaluation = new System.Windows.Forms.Button();
			this.btnDeleteEvaluation = new System.Windows.Forms.Button();
			this.lblTakeEvaluation = new System.Windows.Forms.LinkLabel();
			this.lblManageAll = new System.Windows.Forms.LinkLabel();
			this.lblExit = new System.Windows.Forms.LinkLabel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblNameEvaluation
			// 
			this.lblNameEvaluation.AutoSize = true;
			this.lblNameEvaluation.Location = new System.Drawing.Point(41, 63);
			this.lblNameEvaluation.Name = "lblNameEvaluation";
			this.lblNameEvaluation.Size = new System.Drawing.Size(35, 13);
			this.lblNameEvaluation.TabIndex = 0;
			this.lblNameEvaluation.Text = "Name";
			// 
			// lblTotalMarks
			// 
			this.lblTotalMarks.AutoSize = true;
			this.lblTotalMarks.Location = new System.Drawing.Point(41, 134);
			this.lblTotalMarks.Name = "lblTotalMarks";
			this.lblTotalMarks.Size = new System.Drawing.Size(63, 13);
			this.lblTotalMarks.TabIndex = 1;
			this.lblTotalMarks.Text = "Total Marks";
			// 
			// lblTotalWeightage
			// 
			this.lblTotalWeightage.AutoSize = true;
			this.lblTotalWeightage.Location = new System.Drawing.Point(41, 199);
			this.lblTotalWeightage.Name = "lblTotalWeightage";
			this.lblTotalWeightage.Size = new System.Drawing.Size(86, 13);
			this.lblTotalWeightage.TabIndex = 2;
			this.lblTotalWeightage.Text = "Total Weightage";
			// 
			// txtNameEvaluation
			// 
			this.txtNameEvaluation.Location = new System.Drawing.Point(166, 63);
			this.txtNameEvaluation.Name = "txtNameEvaluation";
			this.txtNameEvaluation.Size = new System.Drawing.Size(100, 20);
			this.txtNameEvaluation.TabIndex = 3;
			// 
			// txtTotalMarks
			// 
			this.txtTotalMarks.Location = new System.Drawing.Point(166, 127);
			this.txtTotalMarks.Name = "txtTotalMarks";
			this.txtTotalMarks.Size = new System.Drawing.Size(100, 20);
			this.txtTotalMarks.TabIndex = 4;
			// 
			// txtTotalWeightage
			// 
			this.txtTotalWeightage.Location = new System.Drawing.Point(166, 199);
			this.txtTotalWeightage.Name = "txtTotalWeightage";
			this.txtTotalWeightage.Size = new System.Drawing.Size(100, 20);
			this.txtTotalWeightage.TabIndex = 5;
			// 
			// btnAddEvaluation
			// 
			this.btnAddEvaluation.Location = new System.Drawing.Point(29, 280);
			this.btnAddEvaluation.Name = "btnAddEvaluation";
			this.btnAddEvaluation.Size = new System.Drawing.Size(75, 37);
			this.btnAddEvaluation.TabIndex = 6;
			this.btnAddEvaluation.Text = "Add Evaluation";
			this.btnAddEvaluation.UseVisualStyleBackColor = true;
			this.btnAddEvaluation.Click += new System.EventHandler(this.btnAddEvaluation_Click);
			// 
			// btnUpdateEvaluation
			// 
			this.btnUpdateEvaluation.Location = new System.Drawing.Point(137, 280);
			this.btnUpdateEvaluation.Name = "btnUpdateEvaluation";
			this.btnUpdateEvaluation.Size = new System.Drawing.Size(75, 37);
			this.btnUpdateEvaluation.TabIndex = 7;
			this.btnUpdateEvaluation.Text = "Update Evaluation";
			this.btnUpdateEvaluation.UseVisualStyleBackColor = true;
			this.btnUpdateEvaluation.Click += new System.EventHandler(this.btnUpdateEvaluation_Click);
			// 
			// btnDeleteEvaluation
			// 
			this.btnDeleteEvaluation.Location = new System.Drawing.Point(248, 283);
			this.btnDeleteEvaluation.Name = "btnDeleteEvaluation";
			this.btnDeleteEvaluation.Size = new System.Drawing.Size(75, 34);
			this.btnDeleteEvaluation.TabIndex = 8;
			this.btnDeleteEvaluation.Text = "Delete Evaluation";
			this.btnDeleteEvaluation.UseVisualStyleBackColor = true;
			this.btnDeleteEvaluation.Click += new System.EventHandler(this.btnDeleteEvaluation_Click);
			// 
			// lblTakeEvaluation
			// 
			this.lblTakeEvaluation.AutoSize = true;
			this.lblTakeEvaluation.Location = new System.Drawing.Point(238, 368);
			this.lblTakeEvaluation.Name = "lblTakeEvaluation";
			this.lblTakeEvaluation.Size = new System.Drawing.Size(85, 13);
			this.lblTakeEvaluation.TabIndex = 9;
			this.lblTakeEvaluation.TabStop = true;
			this.lblTakeEvaluation.Text = "Take Evaluation";
			this.lblTakeEvaluation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTakeEvaluation_LinkClicked);
			// 
			// lblManageAll
			// 
			this.lblManageAll.AutoSize = true;
			this.lblManageAll.Location = new System.Drawing.Point(70, 368);
			this.lblManageAll.Name = "lblManageAll";
			this.lblManageAll.Size = new System.Drawing.Size(57, 13);
			this.lblManageAll.TabIndex = 11;
			this.lblManageAll.TabStop = true;
			this.lblManageAll.Text = "ManageAll";
			this.lblManageAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblManageAll_LinkClicked);
			// 
			// lblExit
			// 
			this.lblExit.AutoSize = true;
			this.lblExit.Location = new System.Drawing.Point(26, 368);
			this.lblExit.Name = "lblExit";
			this.lblExit.Size = new System.Drawing.Size(24, 13);
			this.lblExit.TabIndex = 10;
			this.lblExit.TabStop = true;
			this.lblExit.Text = "Exit";
			this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(361, 63);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(263, 156);
			this.dataGridView1.TabIndex = 12;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(1, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(359, 57);
			this.richTextBox1.TabIndex = 45;
			this.richTextBox1.Text = "Note:Click on the row from GridView for Extracting data then UPDATE Oor DELETE";
			// 
			// Manage_Evaluation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(654, 444);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.lblManageAll);
			this.Controls.Add(this.lblExit);
			this.Controls.Add(this.lblTakeEvaluation);
			this.Controls.Add(this.btnDeleteEvaluation);
			this.Controls.Add(this.btnUpdateEvaluation);
			this.Controls.Add(this.btnAddEvaluation);
			this.Controls.Add(this.txtTotalWeightage);
			this.Controls.Add(this.txtTotalMarks);
			this.Controls.Add(this.txtNameEvaluation);
			this.Controls.Add(this.lblTotalWeightage);
			this.Controls.Add(this.lblTotalMarks);
			this.Controls.Add(this.lblNameEvaluation);
			this.Name = "Manage_Evaluation";
			this.Text = "Manage_Evaluation";
			this.Load += new System.EventHandler(this.Manage_Evaluation_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNameEvaluation;
		private System.Windows.Forms.Label lblTotalMarks;
		private System.Windows.Forms.Label lblTotalWeightage;
		private System.Windows.Forms.TextBox txtNameEvaluation;
		private System.Windows.Forms.TextBox txtTotalMarks;
		private System.Windows.Forms.TextBox txtTotalWeightage;
		private System.Windows.Forms.Button btnAddEvaluation;
		private System.Windows.Forms.Button btnUpdateEvaluation;
		private System.Windows.Forms.Button btnDeleteEvaluation;
		private System.Windows.Forms.LinkLabel lblTakeEvaluation;
		private System.Windows.Forms.LinkLabel lblManageAll;
		private System.Windows.Forms.LinkLabel lblExit;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}