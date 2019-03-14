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
	public partial class Project_Advisor : Form
	{
		SqlConnection con = new SqlConnection("Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True");
		public Project_Advisor()
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

		private void btnAssignProjectAdvisor_Click(object sender, EventArgs e)
		{
			int advisorRole = 0;
			int studentid = 0;
			int groupid = 0;
			int projectid = 0;
			int advisorid = 0;

			if (cbAdvisorRole.Text== "Main Advisor")
			{
				advisorRole = 11;
			}
			else if (cbAdvisorRole.Text== "Co-Advisror")
			{
				advisorRole = 12;
			}
			else if (cbAdvisorRole.Text== "Industry Advisor")
			{
				advisorRole = 13;
			}
			int designation = 0;
			if (cbDesignation.Text == "Professor")
			{
				designation = 6;
			}
			else if (cbDesignation.Text == "Associate Professor")
			{
				designation = 7;
			}
			else if (cbDesignation.Text == "Assisstant Professor")
			{
				designation = 8;
			}
			else if (cbDesignation.Text == "Lecturer")
			{
				designation = 9;
			}
			else if (cbDesignation.Text == "Industry Professional")
			{
				designation = 10;
			}

			con.Open();
			SqlCommand command;
			
			//Query to get AdvisorId...
			string sql2 = "";
			SqlCommand command2;
			SqlDataAdapter adapter2 = new SqlDataAdapter();
			sql2 = "SELECT Id FROM [ProjectA].[dbo].[Advisor] where Designation = '"+designation +"'";
			command2 = new SqlCommand(sql2, con);
			SqlDataReader reader = command2.ExecuteReader();
			while (reader.Read())
			{
				int value = int.Parse(reader[0].ToString());
				advisorid = value;
			}
			command2.Dispose();
			con.Close();



			//Query to get StudentId for finding The GroupId...
			con.Open();
			string sql6 = "";
			SqlCommand command6;
			SqlDataAdapter adapter6 = new SqlDataAdapter();
			sql6 = "SELECT Id FROM [ProjectA].[dbo].[Student] where RegistrationNo = '" + txtRegistrationNo.Text + "'";
			command6 = new SqlCommand(sql6, con);
			SqlDataReader reader6 = command6.ExecuteReader();
			while (reader6.Read())
			{
				int value = int.Parse(reader6[0].ToString());
				studentid = value;
			}
			command6.Dispose();
			con.Close();

			//Query to get GroupId...
			con.Open();
			string sql7 = "";
			SqlCommand command7;
			SqlDataAdapter adapter7 = new SqlDataAdapter();
			sql7 = "SELECT GroupId FROM [ProjectA].[dbo].[GroupStudent] where StudentId = '" + studentid + "'";
			command7 = new SqlCommand(sql7, con);
			SqlDataReader reader7 = command7.ExecuteReader();
			while (reader7.Read())
			{
				int value = int.Parse(reader7[0].ToString());
				groupid = value;
			}
			command7.Dispose();
			con.Close();




			//Query to get ProjectId...
			con.Open();
			string sql3 = " ";
			SqlCommand command3;
			SqlDataAdapter adapter3 = new SqlDataAdapter();
			sql3 = "select ProjectId from [ProjectA].[dbo].[GroupProject] where GroupId = '"+groupid+"'";
			command3 = new SqlCommand(sql3, con);
			SqlDataReader reader1 = command3.ExecuteReader();
			while (reader1.Read())
			{
				int value = int.Parse(reader1[0].ToString());
				projectid = value;
			}
			command3.Dispose();
			con.Close();
			//For assigning a Advisor to a group...
			con.Open();
			SqlCommand command1;
			SqlDataAdapter adapter1 = new SqlDataAdapter();
			string sql1 = "";
			command1 = new SqlCommand(sql1, con);

			sql1 = "insert into  ProjectAdvisor (AdvisorId,ProjectId,AdvisorRole,AssignmentDate) values('" + advisorid + "','" + projectid + "','"+ advisorRole +"','" + txtAssignmentDate.Text + "')";
			command = new SqlCommand(sql1, con);
			adapter1.InsertCommand = new SqlCommand(sql1, con);
			adapter1.InsertCommand.ExecuteNonQuery();
			MessageBox.Show("Advisor has been assigned sucessfully.");
			command.Dispose();
			con.Close();
		}

		private void Project_Advisor_Load(object sender, EventArgs e)
		{
			string currentDate = DateTime.Now.ToString("yyyyMMdd");
			txtAssignmentDate.Text = currentDate;
		}

		private void lblDesignation_Click(object sender, EventArgs e)
		{

		}
	}
}
