namespace ProjectA
{
	partial class Take_Evaluation
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
			this.btnEvaluate = new System.Windows.Forms.Button();
			this.lblObtainedMarks = new System.Windows.Forms.Label();
			this.lblEvaluationDate = new System.Windows.Forms.Label();
			this.txtObtainedMarks = new System.Windows.Forms.TextBox();
			this.txtEvaluationDate = new System.Windows.Forms.TextBox();
			this.lblExit = new System.Windows.Forms.LinkLabel();
			this.lblManageAll = new System.Windows.Forms.LinkLabel();
			this.txtRegistrationNo = new System.Windows.Forms.TextBox();
			this.lblRegistrationNo = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btnEvaluate
			// 
			this.btnEvaluate.Location = new System.Drawing.Point(163, 207);
			this.btnEvaluate.Name = "btnEvaluate";
			this.btnEvaluate.Size = new System.Drawing.Size(75, 23);
			this.btnEvaluate.TabIndex = 0;
			this.btnEvaluate.Text = "Evaluate";
			this.btnEvaluate.UseVisualStyleBackColor = true;
			this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
			// 
			// lblObtainedMarks
			// 
			this.lblObtainedMarks.AutoSize = true;
			this.lblObtainedMarks.Location = new System.Drawing.Point(98, 82);
			this.lblObtainedMarks.Name = "lblObtainedMarks";
			this.lblObtainedMarks.Size = new System.Drawing.Size(82, 13);
			this.lblObtainedMarks.TabIndex = 1;
			this.lblObtainedMarks.Text = "Obtained Marks";
			// 
			// lblEvaluationDate
			// 
			this.lblEvaluationDate.AutoSize = true;
			this.lblEvaluationDate.Location = new System.Drawing.Point(98, 156);
			this.lblEvaluationDate.Name = "lblEvaluationDate";
			this.lblEvaluationDate.Size = new System.Drawing.Size(83, 13);
			this.lblEvaluationDate.TabIndex = 2;
			this.lblEvaluationDate.Text = "Evaluation Date";
			// 
			// txtObtainedMarks
			// 
			this.txtObtainedMarks.Location = new System.Drawing.Point(256, 82);
			this.txtObtainedMarks.Name = "txtObtainedMarks";
			this.txtObtainedMarks.Size = new System.Drawing.Size(100, 20);
			this.txtObtainedMarks.TabIndex = 3;
			// 
			// txtEvaluationDate
			// 
			this.txtEvaluationDate.Location = new System.Drawing.Point(256, 156);
			this.txtEvaluationDate.Name = "txtEvaluationDate";
			this.txtEvaluationDate.Size = new System.Drawing.Size(100, 20);
			this.txtEvaluationDate.TabIndex = 4;
			// 
			// lblExit
			// 
			this.lblExit.AutoSize = true;
			this.lblExit.Location = new System.Drawing.Point(54, 264);
			this.lblExit.Name = "lblExit";
			this.lblExit.Size = new System.Drawing.Size(24, 13);
			this.lblExit.TabIndex = 5;
			this.lblExit.TabStop = true;
			this.lblExit.Text = "Exit";
			this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
			// 
			// lblManageAll
			// 
			this.lblManageAll.AutoSize = true;
			this.lblManageAll.Location = new System.Drawing.Point(301, 264);
			this.lblManageAll.Name = "lblManageAll";
			this.lblManageAll.Size = new System.Drawing.Size(57, 13);
			this.lblManageAll.TabIndex = 6;
			this.lblManageAll.TabStop = true;
			this.lblManageAll.Text = "ManageAll";
			this.lblManageAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblManageAll_LinkClicked);
			// 
			// txtRegistrationNo
			// 
			this.txtRegistrationNo.Location = new System.Drawing.Point(257, 118);
			this.txtRegistrationNo.Name = "txtRegistrationNo";
			this.txtRegistrationNo.Size = new System.Drawing.Size(100, 20);
			this.txtRegistrationNo.TabIndex = 8;
			// 
			// lblRegistrationNo
			// 
			this.lblRegistrationNo.AutoSize = true;
			this.lblRegistrationNo.Location = new System.Drawing.Point(99, 118);
			this.lblRegistrationNo.Name = "lblRegistrationNo";
			this.lblRegistrationNo.Size = new System.Drawing.Size(103, 13);
			this.lblRegistrationNo.TabIndex = 7;
			this.lblRegistrationNo.Text = "Registration Number";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(-3, 1);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(419, 45);
			this.richTextBox1.TabIndex = 49;
			this.richTextBox1.Text = "Note:Write any student\'s registration number from a single group then evaluate";
			// 
			// Take_Evaluation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 368);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.txtRegistrationNo);
			this.Controls.Add(this.lblRegistrationNo);
			this.Controls.Add(this.lblManageAll);
			this.Controls.Add(this.lblExit);
			this.Controls.Add(this.txtEvaluationDate);
			this.Controls.Add(this.txtObtainedMarks);
			this.Controls.Add(this.lblEvaluationDate);
			this.Controls.Add(this.lblObtainedMarks);
			this.Controls.Add(this.btnEvaluate);
			this.Name = "Take_Evaluation";
			this.Text = "Take_Evaluation";
			this.Load += new System.EventHandler(this.Take_Evaluation_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnEvaluate;
		private System.Windows.Forms.Label lblObtainedMarks;
		private System.Windows.Forms.Label lblEvaluationDate;
		private System.Windows.Forms.TextBox txtObtainedMarks;
		private System.Windows.Forms.TextBox txtEvaluationDate;
		private System.Windows.Forms.LinkLabel lblExit;
		private System.Windows.Forms.LinkLabel lblManageAll;
		private System.Windows.Forms.TextBox txtRegistrationNo;
		private System.Windows.Forms.Label lblRegistrationNo;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}