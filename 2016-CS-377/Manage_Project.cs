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

namespace ProjectA
{
	public partial class Manage_Project : Form
	{
		public Manage_Project()
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

		private void btnAddProject_Click(object sender, EventArgs e)
		{
			try
			{
				string connetionString;
				SqlConnection cnn;
				connetionString = @"Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True";
				cnn = new SqlConnection(connetionString);
				cnn.Open();
				SqlCommand command;
				SqlDataAdapter adapter = new SqlDataAdapter();
				string sql = " ";
				sql = "insert into  Project (Description,Title) values('" + txtDescription.Text + "','" + txtTitle.Text + "')";
				command = new SqlCommand(sql, cnn);
				adapter.InsertCommand = new SqlCommand(sql, cnn);
				adapter.InsertCommand.ExecuteNonQuery();
				command.Dispose();
				cnn.Close();
				MessageBox.Show("Sucessfully added evaluation criteria.");
			}
			catch (Exception)
			{
				MessageBox.Show("some error occurs");
			}
		}

		private void lblAssignProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Group_Project b = new Group_Project();
			b.Show();
			this.Hide();
		}

		private void btnUpdateProject_Click(object sender, EventArgs e)
		{
			SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True");//connection name
			//updating values in Project table...
			int ID = Convert.ToInt32(id);
			string sql = "";

			cnn.Open();
			SqlCommand command;
			SqlDataAdapter adapter = new SqlDataAdapter();
			sql = "update [ProjectA].[dbo].[Project] set Title = '"+txtTitle.Text+"',Description = '"+txtDescription.Text+"' where Id = '" + ID + "' ";
			command = new SqlCommand(sql, cnn);
			adapter.InsertCommand = new SqlCommand(sql, cnn);
			adapter.InsertCommand.ExecuteNonQuery();
			MessageBox.Show("Project has been updated successfully...");
			command.Dispose();
			cnn.Close();
		}

		private void Manage_Project_Load(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection("Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True");//connection name
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
		}
		string id = " ";
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				txtTitle.Text = row.Cells["Title"].Value.ToString();
				txtDescription.Text = row.Cells["Description"].Value.ToString();
				id = row.Cells["Id"].Value.ToString();
			}
		}

		private void btnDeleteProject_Click(object sender, EventArgs e)
		{
			//connection name
			SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True");
			//deleting values in Person table...
			int ID = Convert.ToInt32(id);
			MessageBox.Show(id);
			string sql = "";
			try
			{
				//deleting project from groupProject table...
				string sql1 = " ";
				cnn.Open();
				SqlCommand command1;
				SqlDataAdapter adapter1 = new SqlDataAdapter();
				sql1 = "delete from [ProjectA].[dbo].[GroupProject] where ProjectId = '" + ID + "' ";
				command1 = new SqlCommand(sql1, cnn);
				adapter1.InsertCommand = new SqlCommand(sql1, cnn);
				adapter1.InsertCommand.ExecuteNonQuery();
				command1.Dispose();
				cnn.Close();
				//deleting Project from projectAdvisor table...
				string sql2 = " ";
				cnn.Open();
				SqlCommand command2;
				SqlDataAdapter adapter2 = new SqlDataAdapter();
				sql2 = "delete from [ProjectA].[dbo].[ProjectAdvisor] where ProjectId = '" + ID + "' ";
				command2 = new SqlCommand(sql2, cnn);
				adapter2.InsertCommand = new SqlCommand(sql2, cnn);
				adapter2.InsertCommand.ExecuteNonQuery();
				command2.Dispose();
				cnn.Close();
				//deleting project from project table...
				cnn.Open();
				SqlCommand command;
				SqlDataAdapter adapter = new SqlDataAdapter();
				sql = "delete from [ProjectA].[dbo].[Project] where Id = '" + ID + "' ";
				command = new SqlCommand(sql, cnn);
				adapter.InsertCommand = new SqlCommand(sql, cnn);
				adapter.InsertCommand.ExecuteNonQuery();
				MessageBox.Show("Project has been deleted successfully...");
				command.Dispose();
				cnn.Close();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
//}
