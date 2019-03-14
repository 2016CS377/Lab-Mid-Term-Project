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
using System.Diagnostics;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace ProjectA
{
	public partial class Group_Project : Form
	{
		SqlConnection con = new SqlConnection("Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True");//connection name
		public Group_Project()
		{
			InitializeComponent();
		}

		private void lblManageAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Manage_All a = new Manage_All();
			a.Show();
			this.Hide();
		}

		private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Application.Exit();
		}

		private void Group_Project_Load(object sender, EventArgs e)
		{
			try
			{ 
				con.Open();
				SqlCommand cmd = new SqlCommand("select * from [ProjectA].[dbo].[Project]", con);
				cmd.CommandType = CommandType.Text;
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				da.Fill(ds, "ss");
				dataGridView1.DataSource = ds.Tables["ss"]; 
			}
			catch
			{
				MessageBox.Show("No Record Found");
			}

			string query = "SELECT Title FROM [ProjectA].[dbo].[Project]";      //query the database
			SqlDataReader reader = new SqlCommand(query,con).ExecuteReader();
			while (reader.Read())   //loop reader and fill the combobox
			{
				cbTitle.Items.Add(reader["Title"].ToString());
			}
			string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
			txtAssignmentDate.Text = currentDate;
			reader.Close();
		}

		private void btnAssignProject_Click(object sender, EventArgs e)
		{

			SqlCommand command;
			int projectid = 0;
			projectid = Convert.ToInt32(id);
			int groupid = 0;
			//Query to get GroupId...
			string sql2 = "";
			SqlCommand command2;
			SqlDataAdapter adapter2 = new SqlDataAdapter();
			sql2 = "SELECT MAX(Id) FROM [Group]";
			command2 = new SqlCommand(sql2, con);
			SqlDataReader reader = command2.ExecuteReader();
			while (reader.Read())
			{
				int value = int.Parse(reader[0].ToString());
				groupid = value;
			}
			command2.Dispose();
			con.Close();
			//For assigning a project to a group...
			con.Open();
			SqlCommand command1;
			SqlDataAdapter adapter1 = new SqlDataAdapter();
			string sql1 = "";
			command1 = new SqlCommand(sql1, con);

			sql1 = "insert into  GroupProject (ProjectId,GroupId,AssignmentDate) values('" + projectid + "','" + groupid + "','" + txtAssignmentDate.Text + "')";
			command = new SqlCommand(sql1, con);
			adapter1.InsertCommand = new SqlCommand(sql1, con);
			adapter1.InsertCommand.ExecuteNonQuery();
			MessageBox.Show("Project has been assigned sucessfully.");
			command.Dispose();
			con.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			/*//for txt file...
			TextWriter writer = new StreamWriter(@"E:\uet\6th Semester\Database Management System\Mini Project For MidTerm\Test.txt");
			for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
			{
				for (int j = 0; j <dataGridView1.Columns.Count; j++)
				{
					writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
				}
				writer.WriteLine("");
				writer.WriteLine("----------------------------------");	
			}
			writer.Close();
			MessageBox.Show("Data Exported");*/

			/*Document Doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10,42, 35);
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
			MessageBox.Show("Data Exported");*/


			try
			{
				string connetionString = null;
				SqlConnection connection;
				SqlCommand command;
				SqlDataAdapter adapter = new SqlDataAdapter();
				DataSet ds = new DataSet();
				int i = 0;
				string sql = null;
				int yPoint = 0;
				string FName = null;
				string LName = null;
				string RegNo = null;
				string Contact = null;
				string Email = null;
				string DOB = null;
				string Gender = null;

				connetionString = "Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True";
				sql = "select FirstName,LastName,RegistrationNo,Contact,Email,DateOfBirth,Gender from Person join Student on Person.Id = Student.Id";
				connection = new SqlConnection(connetionString);
				connection.Open();
				command = new SqlCommand(sql, connection);
				adapter.SelectCommand = command;
				adapter.Fill(ds);
				connection.Close();
				PdfDocument pdf = new PdfDocument();
				pdf.Info.Title = "List of Students";
				PdfPage pdfPage = pdf.AddPage();
				XGraphics graph = XGraphics.FromPdfPage(pdfPage);
				XFont font = new XFont("Verdana", 12, XFontStyle.Regular);

				yPoint = yPoint + 400;

				for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
				{
					FName = ds.Tables[0].Rows[i].ItemArray[0].ToString();
					LName = ds.Tables[0].Rows[i].ItemArray[1].ToString();
					RegNo = ds.Tables[0].Rows[i].ItemArray[2].ToString();
					Contact = ds.Tables[0].Rows[i].ItemArray[3].ToString();
					Email = ds.Tables[0].Rows[i].ItemArray[4].ToString();
					DOB = ds.Tables[0].Rows[i].ItemArray[5].ToString();
					Gender = ds.Tables[0].Rows[i].ItemArray[6].ToString();

					graph.DrawString(FName, font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

					graph.DrawString(LName, font, XBrushes.Black, new XRect(280, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

					graph.DrawString(RegNo, font, XBrushes.Black, new XRect(420, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

					graph.DrawString(Contact, font, XBrushes.Black, new XRect(680, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

					graph.DrawString(Email, font, XBrushes.Black, new XRect(820, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

					graph.DrawString(DOB, font, XBrushes.Black, new XRect(1080, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

					graph.DrawString(Gender, font, XBrushes.Black, new XRect(1220, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

					yPoint = yPoint + 40;
				}


				string pdfFilename = "dbtopdf7.pdf";
				pdf.Save(pdfFilename);
				Process.Start(pdfFilename);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		string id = " ";

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				cbTitle.Text = row.Cells["Title"].Value.ToString();
				id = row.Cells["Id"].Value.ToString();
			}
		}
	}



}

