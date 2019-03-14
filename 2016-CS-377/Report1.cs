using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.xmp;
using iTextSharp.text.pdf;

namespace ProjectA
{
	public partial class Report1 : Form
	{
		public Report1()
		{
			InitializeComponent();
		}

		private void Report1_Load(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection("Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True");//connection name
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("select FirstName,LastName,RegistrationNo,Contact,Email,Title,Description,AdvisorRole,Designation,Salary  from Person inner join Student on Person.Id=Student.Id inner join GroupStudent on Student.Id=GroupStudent.StudentId inner join GroupProject on GroupStudent.GroupId=GroupProject.GroupId inner join Project on GroupProject.ProjectId=Project.Id inner join ProjectAdvisor on GroupProject.ProjectId=ProjectAdvisor.ProjectId inner join Advisor on ProjectAdvisor.AdvisorId=Advisor.Id", con);
				cmd.CommandType = CommandType.Text;
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				da.Fill(ds, "ss");
				dataGridView1.DataSource = ds.Tables["ss"];
				con.Close();
			}
			catch
			{
				MessageBox.Show("No Record Found");
			}

			try

			{
				SqlCommand com;

				com = new SqlCommand();

				com.Connection = con;

				com.CommandText = "select FirstName,LastName,RegistrationNo,Status,TotalMarks,TotalWeightage,ObtainedMarks,Name,EvaluationDate from Person inner join Student on Person.Id = Student.Id inner join GroupStudent on Student.Id = GroupStudent.StudentId inner join [ProjectA].[dbo].[GroupEvaluation] on GroupStudent.GroupId = GroupEvaluation.GroupId inner join Evaluation on GroupEvaluation.EvaluationId = Evaluation.Id";

				con.Open();

				SqlDataReader reader = com.ExecuteReader();

				if (reader.HasRows)

				{

					DataTable dt = new DataTable();

					dt.Load(reader);

					dataGridView2.DataSource = dt;

				}
				con.Close();
			}

			catch(Exception ex)

			{

				MessageBox.Show(ex.ToString());

			}
		}

		private void btnReport1_Click(object sender, EventArgs e)
		{
			Document Doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10,42, 35);
			PdfWriter wri = PdfWriter.GetInstance(Doc, new FileStream("Projects List.pdf", FileMode.Create));
			Doc.Open();//open document to write...
			PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
			//add the headers from the data grid view to the table...
			for (int j = 0; j < dataGridView1.Columns.Count; j++)
			{
				table.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText));
			}

			//flag the first row as a header..
			table.HeaderRows = 1;

			//add the actual rows from data grid view to the table..
			for (int i = 0;i<dataGridView1.Rows.Count; i++)
			{
				for (int k = 0;k<dataGridView1.Columns.Count; k++)
				{
					if (dataGridView1[k, i].Value != null)
					{
						table.AddCell(new Phrase(dataGridView1[k, i].Value.ToString()));
					}
				}
			}
			//Add out table...
			Doc.Add(table);
			//close document
			Doc.Close();
			MessageBox.Show("Data Exported");
		}

		private void btnReport2_Click(object sender, EventArgs e)
		{
			Document Doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
			PdfWriter wri = PdfWriter.GetInstance(Doc, new FileStream("Evaluations List.pdf", FileMode.Create));
			Doc.Open();//open document to write...
			PdfPTable table = new PdfPTable(dataGridView2.Columns.Count);
			//add the headers from the data grid view to the table...
			for (int j = 0; j < dataGridView2.Columns.Count; j++)
			{
				table.AddCell(new Phrase(dataGridView2.Columns[j].HeaderText));
			}

			//flag the first row as a header..
			table.HeaderRows = 1;

			//add the actual rows from data grid view to the table..
			for (int i = 0; i < dataGridView2.Rows.Count; i++)
			{
				for (int k = 0; k < dataGridView2.Columns.Count; k++)
				{
					if (dataGridView2[k, i].Value != null)
					{
						table.AddCell(new Phrase(dataGridView2[k, i].Value.ToString()));
					}
				}
			}
			//Add out table...
			Doc.Add(table);
			//close document
			Doc.Close();
			MessageBox.Show("Data Exported");
		}

		private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Application.Exit();
		}

		private void lblManageAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Manage_All a = new Manage_All();
			a.Show();
			this.Hide();
		}
	}
}
