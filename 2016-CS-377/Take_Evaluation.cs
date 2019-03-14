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
	public partial class Take_Evaluation : Form
	{
		public Take_Evaluation()
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

		private void btnEvaluate_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection("Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True");//connection name
			con.Open();
			SqlCommand command;
			int evaluationid = 0;
			int Studentid = 0;
			int groupid = 0;
			//Query to get StudentId for finding The GroupId...
			string sql2 = "";
			SqlCommand command2;
			SqlDataAdapter adapter2 = new SqlDataAdapter();
			sql2 = "SELECT Id FROM [ProjectA].[dbo].[Student] where RegistrationNo = '"+txtRegistrationNo.Text+"'";
			command2 = new SqlCommand(sql2, con);
			SqlDataReader reader = command2.ExecuteReader();
			while (reader.Read())
			{
				int value = int.Parse(reader[0].ToString());
				Studentid = value;
			}
			command2.Dispose();
			con.Close();

			//Query to get GroupId...
			con.Open();
			string sql4 = "";
			SqlCommand command4;
			SqlDataAdapter adapter4 = new SqlDataAdapter();
			sql4 = "SELECT GroupId FROM [ProjectA].[dbo].[GroupStudent] where StudentId = '" + Studentid + "'";
			command4 = new SqlCommand(sql4, con);
			SqlDataReader reader2 = command4.ExecuteReader();
			while (reader2.Read())
			{
				int value = int.Parse(reader2[0].ToString());
				groupid = value;
				MessageBox.Show(Convert.ToString(groupid));
			}
			command4.Dispose();
			con.Close();

			//Query to get EvaluationId...
			con.Open();
			string sql3 = " ";
			SqlCommand command3;
			SqlDataAdapter adapter3 = new SqlDataAdapter();
			sql3 = "select MAX(Id) from [ProjectA].[dbo].[Evaluation]";
			command3 = new SqlCommand(sql3, con);
			SqlDataReader reader1 = command3.ExecuteReader();
			while (reader1.Read())
			{
				int value = int.Parse(reader1[0].ToString());
				evaluationid = value;
			}
			command3.Dispose();
			con.Close();
			//For taking evaluation of a group...
			con.Open();
			SqlCommand command1;
			SqlDataAdapter adapter1 = new SqlDataAdapter();
			string sql1 = "";
			command1 = new SqlCommand(sql1, con);

			sql1 = "insert into  GroupEvaluation (GroupId,EvaluationId,ObtainedMarks,EvaluationDate) values('" + groupid + "','" + evaluationid + "','" + txtObtainedMarks.Text+"','" + txtEvaluationDate.Text + "')";
			command = new SqlCommand(sql1, con);
			adapter1.InsertCommand = new SqlCommand(sql1, con);
			adapter1.InsertCommand.ExecuteNonQuery();
			MessageBox.Show("Evaluation has been taken sucessfully.");
			command.Dispose();
			con.Close();
		}

		private void Take_Evaluation_Load(object sender, EventArgs e)
		{
			string currentDate = DateTime.Now.ToString("yyyyMMdd");
			txtEvaluationDate.Text = currentDate;
		}
	}
}
