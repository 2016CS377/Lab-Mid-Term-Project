using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace ProjectA
{
	public partial class Manage_Groups : Form
	{
		//setting a current date time
		string currentDate = DateTime.Now.ToString("yyyyMMdd");
		public Manage_Groups()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

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

		private void btnCreateGroup_Click(object sender, EventArgs e)
		{
			string connetionString;
			SqlConnection cnn;
			connetionString = @"Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True";
			cnn = new SqlConnection(connetionString);
			cnn.Open();
			SqlCommand command;
			SqlDataAdapter adapter = new SqlDataAdapter();
			string sql = " ";
			sql = "insert into [ProjectA].[dbo].[Group] ([Created_On]) values('"+currentDate+"')";
			command = new SqlCommand(sql, cnn);
			adapter.InsertCommand = new SqlCommand(sql, cnn);
			adapter.InsertCommand.ExecuteNonQuery();
			command.Dispose();
			cnn.Close();
			MessageBox.Show("Successfully created a group.");
			txtCreatedOn.Text = " ";
		}

		private void Manage_Groups_Load(object sender, EventArgs e)
		{
			txtCreatedOn.Text = currentDate;
			try
			{

				SqlConnection con = new SqlConnection("Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True");//connection name

				con.Open();

				SqlCommand cmd = new SqlCommand("select * from [ProjectA].[dbo].[Group]", con);

				cmd.CommandType = CommandType.Text;

				SqlDataAdapter da = new SqlDataAdapter(cmd);

				DataSet ds = new DataSet();

				da.Fill(ds, "ss");

				dataGridView1.DataSource = ds.Tables["ss"]; ;

				// dataGridView1.DataBind();

			}

			catch

			{

				MessageBox.Show("No Record Found");

			}

		}

		private void lblGroupStudents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Group_Students s = new Group_Students();
			s.Show();
			this.Hide();
		}
		string id = " ";
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>= 0)
			{
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				txtCreatedOn.Text = row.Cells["Created_On"].Value.ToString();
				id = row.Cells["Id"].Value.ToString();
			}
		}

		private void btnUpdateGroup_Click_1(object sender, EventArgs e)
		{
			SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True");//connection name
			//updating values in Person table...
			int ID = Convert.ToInt32(id);
			string sql = "";
			
				cnn.Open();
				SqlCommand command;
				SqlDataAdapter adapter = new SqlDataAdapter();
				sql = "update [ProjectA].[dbo].[Group] set Created_On = '"+txtCreatedOn.Text+"' where Id = '"+ID+"' ";
				command = new SqlCommand(sql, cnn);
				adapter.InsertCommand = new SqlCommand(sql, cnn);
				adapter.InsertCommand.ExecuteNonQuery();
				MessageBox.Show("Group has been updated successfully...");
				command.Dispose();
				cnn.Close();


			cnn.Close();
		}

		private void btnDeleteAdvisor_Click(object sender, EventArgs e)
		{
			SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True");//connection name
																																   //updating values in Person table...
			int ID = Convert.ToInt32(id);
			string sql = "";
			try
			{
				//deleting group from groupProject table...
				string sql1 = " ";
				cnn.Open();
				SqlCommand command1;
				SqlDataAdapter adapter1 = new SqlDataAdapter();
				sql1 = "delete from [ProjectA].[dbo].[GroupProject] where GroupId = '" + ID + "' ";
				command1 = new SqlCommand(sql1, cnn);
				adapter1.InsertCommand = new SqlCommand(sql1, cnn);
				adapter1.InsertCommand.ExecuteNonQuery();
				command1.Dispose();
				cnn.Close();
				//deleting group from groupstudents table...
				string sql2 = " ";
				cnn.Open();
				SqlCommand command2;
				SqlDataAdapter adapter2 = new SqlDataAdapter();
				sql2 = "delete from [ProjectA].[dbo].[GroupStudent] where Id = '" + ID + "' ";
				command2 = new SqlCommand(sql2, cnn);
				adapter2.InsertCommand = new SqlCommand(sql2, cnn);
				adapter2.InsertCommand.ExecuteNonQuery();
				command2.Dispose();
				cnn.Close();
				//deleting group from group table...
				cnn.Open();
				SqlCommand command;
				SqlDataAdapter adapter = new SqlDataAdapter();
				sql = "delete from [ProjectA].[dbo].[Group] where Id = '" + ID + "' ";
				command = new SqlCommand(sql, cnn);
				adapter.InsertCommand = new SqlCommand(sql, cnn);
				adapter.InsertCommand.ExecuteNonQuery();
				MessageBox.Show("Group has been deleted successfully...");
				command.Dispose();
				cnn.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Please Enter Valid date");
			}


			cnn.Close();
		}
	}
	}
