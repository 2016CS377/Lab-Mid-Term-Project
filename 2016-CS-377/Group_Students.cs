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
using System.Data.OleDb;

namespace ProjectA
{
	public partial class Group_Students : Form
	{
		public Group_Students()
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

		private void Group_Students_Load(object sender, EventArgs e)
		{
			listBox1.SelectionMode = SelectionMode.MultiExtended;
			listBox2.SelectionMode = SelectionMode.MultiExtended;
			SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True"); //connection name
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("select * from Student", cnn);
			da.Fill(dt);
			foreach (DataRow row in dt.Rows)
			{
				listBox1.Items.Add(row["RegistrationNo"].ToString());
			}
		}

		private void btnGroupStudents_Click(object sender, EventArgs e)
		{
			
			List<String> arr = new List<String>();
			foreach(string str in listBox2.Items)
			{
				arr.Add(str);
			}

			int status = 0;
			if (cbStatus.Text == "Active")
			{
				status = 3;
			}
			else if (cbStatus.Text == "InActive")
			{
				status = 4;
			}
			//connecting string...
			string connetionString;
			SqlConnection cnn;
			connetionString = @"Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True";
			cnn = new SqlConnection(connetionString);

			for (int i = 0; i < arr.Count; i++)
			{
				cnn.Open();
				SqlCommand command;
				int Grouid = 0;
				int Studentid = 0;
				//Query to get GroupId...
				string sql2 = "";
				SqlCommand command2;
				SqlDataAdapter adapter2 = new SqlDataAdapter();
				sql2 = "SELECT MAX(Id) FROM [Group]";
				command2 = new SqlCommand(sql2, cnn);
				SqlDataReader reader = command2.ExecuteReader();
				while (reader.Read())
				{
					int value = int.Parse(reader[0].ToString());
					Grouid = value;
				}
				command2.Dispose();
				cnn.Close();

				//Query to get StudentId...
				cnn.Open();
				string sql3 = " ";
				SqlCommand command3;
				SqlDataAdapter adapter3 = new SqlDataAdapter();
				sql3 = "select Id from Student where RegistrationNo = '" + arr[i] + "'";
				command3 = new SqlCommand(sql3, cnn);
				SqlDataReader reader1 = command3.ExecuteReader();
				while (reader1.Read())
				{
					int value = int.Parse(reader1[0].ToString());
					Studentid = value;
				}
				command3.Dispose();
				cnn.Close();
				//For adding students in a group table...
				cnn.Open();
				SqlCommand command1;
				SqlDataAdapter adapter1 = new SqlDataAdapter();
				string sql1 = "";
				command1 = new SqlCommand(sql1, cnn);
				
				sql1 = "insert into  GroupStudent (GroupId,StudentId,Status,AssignmentDate) values('" + Grouid + "','" + Studentid + "','" + status + "','" + txtAssignmentDate.Text + "')";
				command = new SqlCommand(sql1, cnn);
				adapter1.InsertCommand = new SqlCommand(sql1, cnn);
				adapter1.InsertCommand.ExecuteNonQuery();
				command.Dispose();
				cnn.Close();
			}
			MessageBox.Show("Students have been grouped successfully.");
			txtAssignmentDate.Text = " ";
			cbStatus.Text = " ";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			listBox2.Items.Add(listBox1.SelectedItem);
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void lblAssignProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Group_Project n = new Group_Project();
			n.Show();
			this.Hide();
		}
	}
}
