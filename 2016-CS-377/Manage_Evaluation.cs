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

namespace ProjectA
{
	public partial class Manage_Evaluation : Form
	{
		public Manage_Evaluation()
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

		private void btnAddEvaluation_Click(object sender, EventArgs e)
		{
			string connetionString;
			SqlConnection cnn;
			connetionString = @"Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True";
			cnn = new SqlConnection(connetionString);
			cnn.Open();
			SqlCommand command;
			SqlDataAdapter adapter = new SqlDataAdapter();
			string sql = "";
			sql = "insert into  Evaluation (Name,TotalMarks,TotalWeightage) values('" + txtNameEvaluation.Text + "','" + txtTotalMarks.Text + "','"+txtTotalWeightage.Text+"')";
			command = new SqlCommand(sql, cnn);
			adapter.InsertCommand = new SqlCommand(sql, cnn);
			adapter.InsertCommand.ExecuteNonQuery();
			command.Dispose();
			cnn.Close();
			MessageBox.Show("Sucessfully added evaluation criteria.");

		}

		private void lblTakeEvaluation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Take_Evaluation b = new Take_Evaluation();
			b.Show();
			this.Hide();
		}

		private void btnUpdateEvaluation_Click(object sender, EventArgs e)
		{
			int ID = Convert.ToInt32(id);
			MessageBox.Show(id);
			string sql = " ";
			SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True");//connection name
			cnn.Open();
			SqlCommand command;
			SqlDataAdapter adapter = new SqlDataAdapter();
			sql = "update [ProjectA].[dbo].[Evaluation] set Name = '"+txtNameEvaluation.Text+ "',TotalMarks = '" + txtTotalMarks.Text+ "',TotalWeightage = '"+txtTotalWeightage.Text+"' where Id = '" + ID + "' ";
			command = new SqlCommand(sql, cnn);
			adapter.InsertCommand = new SqlCommand(sql, cnn);
			adapter.InsertCommand.ExecuteNonQuery();
			MessageBox.Show("Evaluation has been updated successfully...");
			command.Dispose();
			cnn.Close();
		}

		private void Manage_Evaluation_Load(object sender, EventArgs e)
		{
			try
			{

				SqlConnection con = new SqlConnection("Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True");//connection name

				con.Open();

				SqlCommand cmd = new SqlCommand("select * from [ProjectA].[dbo].[Evaluation]", con);

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
		string id = "";
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				txtNameEvaluation.Text = row.Cells["Name"].Value.ToString();
				txtTotalMarks.Text = row.Cells["TotalMarks"].Value.ToString();
				txtTotalWeightage.Text = row.Cells["TotalWeightage"].Value.ToString();
				id = row.Cells["Id"].Value.ToString();
			}
		}

		private void btnDeleteEvaluation_Click(object sender, EventArgs e)
		{
			int ID = Convert.ToInt32(id);
			MessageBox.Show(id);
			string sql = " ";
			SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True");//connection name
			cnn.Open();
			SqlCommand command;
			SqlDataAdapter adapter = new SqlDataAdapter();
			sql = "delete from [ProjectA].[dbo].[Evaluation] where Id = '" + ID + "' ";
			command = new SqlCommand(sql, cnn);
			adapter.InsertCommand = new SqlCommand(sql, cnn);
			adapter.InsertCommand.ExecuteNonQuery();
			command.Dispose();
			cnn.Close();
			//deleting evaluation from groupevaluation...
			string sql1 = " ";
			cnn.Open();
			SqlCommand command1;
			SqlDataAdapter adapter1 = new SqlDataAdapter();
			sql1 = "delete from [ProjectA].[dbo].[GroupEvaluation] where EvaluationId = '" + ID + "' ";
			command1 = new SqlCommand(sql1, cnn);
			adapter1.InsertCommand = new SqlCommand(sql1, cnn);
			adapter1.InsertCommand.ExecuteNonQuery();

			MessageBox.Show("Evaluation has been deleted successfully...");
			command1.Dispose();
			cnn.Close();
		}
	}
}
