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
	public partial class Manage_Advisors : Form
	{
		public Manage_Advisors()
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

		private void btnAddAdvisor_Click(object sender, EventArgs e)
		{
			string connetionString;
			SqlConnection cnn;
			connetionString = @"Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True";
			cnn = new SqlConnection(connetionString);
			cnn.Open();
			SqlCommand command;
			SqlDataAdapter adapter = new SqlDataAdapter();
			string sql = "";
			string gender = " ";
			if (btnFemale.Checked)
			{
				gender = "2";
			}
			else if (btnMale.Checked)
			{
				gender = "1";
			}
			sql = "insert into  Person (FirstName,LastName,Contact,Email,DateOfBirth,Gender) values('" + txtFName.Text + "','" + txtLName.Text + "','" + txtContact.Text + "','" + txtEmail.Text + "','" + txtDOB.Text + "','" + gender + "')";
			command = new SqlCommand(sql, cnn);
			adapter.InsertCommand = new SqlCommand(sql, cnn);
			adapter.InsertCommand.ExecuteNonQuery();
			command.Dispose();
			cnn.Close();
			//Query to get Id...
			cnn.Open();
			string id = " ";
			string sql2 = "";
			SqlCommand command2;
			SqlDataAdapter adapter2 = new SqlDataAdapter();
			sql2 = "select IDENT_CURRENT('Person')";
			command2 = new SqlCommand(sql2, cnn);
			SqlDataReader reader = command2.ExecuteReader();
			while (reader.Read())
			{
				int value = int.Parse(reader[0].ToString());
				id = value.ToString();
			}
			command.Dispose();
			cnn.Close();
			//For adding data in Advisor table...
			cnn.Open();
			SqlCommand command1;
			SqlDataAdapter adapter1 = new SqlDataAdapter();
			string sql1 = "";
			command1 = new SqlCommand(sql1, cnn);
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
			sql1 = "insert into  Advisor (Id,Designation,Salary) values('" + id + "','" + designation+ "','"+Convert.ToInt32(txtSalary.Text)+"')";
			command = new SqlCommand(sql1, cnn);
			adapter1.InsertCommand = new SqlCommand(sql1, cnn);
			adapter1.InsertCommand.ExecuteNonQuery();
			MessageBox.Show("Advisor has been added successfully.");
			txtFName.Text = " ";
			txtLName.Text = " ";
			txtContact.Text = " ";
			txtDOB.Text = " ";
			txtEmail.Text = " ";
			txtSalary.Text = " ";
			cbDesignation.Text = " ";
			btnFemale.Checked = false;
			btnMale.Checked = false;
			command.Dispose();
			cnn.Close();

		}

		private void lblAssignAdvisor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Project_Advisor b = new Project_Advisor();
			b.Show();
			this.Hide();
		}

		private void Manage_Advisors_Load(object sender, EventArgs e)
		{

		}

		private void btnUpdateAdvisor_Click(object sender, EventArgs e)
		{
			int designation = 0;
			string connetionString;
			SqlConnection cnn;
			connetionString = @"Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True";
			cnn = new SqlConnection(connetionString);
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
			string gender = " ";
			if (btnFemale.Checked)
			{
				gender = "2";
			}
			else if (btnMale.Checked)
			{
				gender = "1";
			}
			//Query to get Id...
			cnn.Open();
			string id = " ";
			string sql2 = "";
			SqlCommand command2;
			SqlDataAdapter adapter2 = new SqlDataAdapter();
			sql2 = "select Id from Advisor where Designation = '" + designation + "' and Salary = '"+txtSalary.Text+"'";
			command2 = new SqlCommand(sql2, cnn);
			SqlDataReader reader = command2.ExecuteReader();
			while (reader.Read())
			{
				int value = int.Parse(reader[0].ToString());
				id = value.ToString();
			}
			command2.Dispose();
			cnn.Close();


			//updating values in Advisor table...

			string sql = "";
			try
			{
				cnn.Open();
				SqlCommand command;
				SqlDataAdapter adapter = new SqlDataAdapter();
				sql = "update Person set Designation = '"+designation+"', Salary = '"+txtSalary.Text+"' where Id = '"+id+"'";
				command = new SqlCommand(sql, cnn);
				adapter.InsertCommand = new SqlCommand(sql, cnn);
				adapter.InsertCommand.ExecuteNonQuery();
				command.Dispose();
				cnn.Close();
			}
			catch (Exception)
			{
				
			}


			cnn.Close();
			cnn.Close();
			cnn.Close();
			cnn.Close();
			try
			{
				//For updating data in Person table...
				cnn.Open();
				SqlCommand command1;
				SqlDataAdapter adapter1 = new SqlDataAdapter();
				string sql1 = "";
				command1 = new SqlCommand(sql1, cnn);
				sql1 = "update Person set FirstName = '" + txtFName.Text + "',LastName = '" + txtLName.Text + "',Contact = '" + txtContact.Text + "',Email = '" + txtEmail.Text + "',DateOfBirth = '" + txtDOB.Text + "',Gender = '" + int.Parse(gender) + "' where Id = '" + id + "'";
				command1 = new SqlCommand(sql1, cnn);
				adapter1.InsertCommand = new SqlCommand(sql1, cnn);
				adapter1.InsertCommand.ExecuteNonQuery();
				MessageBox.Show("Advisor has been updated successfully.");
				command1.Dispose();
				cnn.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Please enter the date in correct format");
			}
			txtFName.Text = " ";
			txtLName.Text = " ";
			txtContact.Text = " ";
			txtDOB.Text = " ";
			txtEmail.Text = " ";
			txtSalary.Text = " ";
			btnFemale.Checked = false;
			btnMale.Checked = false;
			cbDesignation.Text = " ";
			
		}

		private void lblExtractData_Click(object sender, EventArgs e)
		{
			int designation = 0;
			string connetionString;
			SqlConnection cnn;
			connetionString = @"Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True";
			cnn = new SqlConnection(connetionString);
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
			//getting data against advisor id..
			cnn.Open();
			string id = " ";
			string sql2 = "";
			SqlCommand command2;
			SqlDataAdapter adapter2 = new SqlDataAdapter();
			sql2 = "select Id from Advisor where Designation = '" + designation + "' and Salary = '"+ txtSalary.Text +"'";
			command2 = new SqlCommand(sql2, cnn);
			SqlDataReader reader = command2.ExecuteReader();
			while (reader.Read())
			{
				int value = int.Parse(reader[0].ToString());
				id = value.ToString();
			}
			command2.Dispose();
			cnn.Close();

			//getting first name of student against its registration no....
			cnn.Open();
			string Fname = " ";
			string sql4 = "";
			SqlCommand command4;
			SqlDataAdapter adapter4 = new SqlDataAdapter();
			sql4 = "select FirstName from Person where Id = '" + id + "'";
			command4 = new SqlCommand(sql4, cnn);
			SqlDataReader reader4 = command4.ExecuteReader();
			while (reader4.Read())
			{
				string value = reader4[0].ToString();
				Fname = value.ToString();
			}
			command4.Dispose();
			cnn.Close();
			//getting last name of student against registration no...
			cnn.Open();
			string Lname = " ";
			string sql5 = "";
			SqlCommand command5;
			SqlDataAdapter adapter5 = new SqlDataAdapter();
			sql5 = "select LastName from Person where Id = '" + id + "'";
			command5 = new SqlCommand(sql5, cnn);
			SqlDataReader reader5 = command5.ExecuteReader();
			while (reader5.Read())
			{
				string value = reader5[0].ToString();
				Lname = value.ToString();
			}
			command5.Dispose();
			cnn.Close();

			//getting contact against advisor registration no....
			cnn.Open();
			SqlCommand command6 = new SqlCommand("select Contact from Person where Id = '" + id + "'", cnn);
			string g = command6.ExecuteScalar().ToString();
			command6.Dispose();
			cnn.Close();

			//getting email against student registration no....
			cnn.Open();
			string email = " ";
			string sql7 = "";
			SqlCommand command7;
			SqlDataAdapter adapter7 = new SqlDataAdapter();
			sql7 = "select Email from Person where Id = '" + id + "'";
			command7 = new SqlCommand(sql7, cnn);
			SqlDataReader reader7 = command7.ExecuteReader();
			while (reader7.Read())
			{
				string value = reader7[0].ToString();
				email = value.ToString();
			}
			command7.Dispose();
			cnn.Close();

			//getting gender against student registration no....
			cnn.Open();
			string Gender = " ";
			string sql8 = "";
			SqlCommand command8;
			SqlDataAdapter adapter8 = new SqlDataAdapter();
			sql8 = "select Gender from Person where Id = '" + id + "'";
			command8 = new SqlCommand(sql8, cnn);
			SqlDataReader reader8 = command8.ExecuteReader();
			while (reader8.Read())
			{
				string value = reader8[0].ToString();
				Gender = value.ToString();
			}
			command8.Dispose();
			cnn.Close();


			//getting dateOfBirth against student registration no....
			cnn.Open();
			DateTime dbo = default(DateTime);
			string d = " ";
			string sql9 = "";
			SqlCommand command9;
			SqlDataAdapter adapter9 = new SqlDataAdapter();
			sql9 = "select DateOfBirth from Person where Id = '" + id + "'";
			command9 = new SqlCommand(sql9, cnn);
			SqlDataReader reader9 = command9.ExecuteReader();
			while (reader9.Read())
			{
				d = dbo.ToString();
				string value = reader9[0].ToString();
				d = value;
			}
			command9.Dispose();
			cnn.Close();




			if (Gender== "1")
			{
				btnMale.Checked = true;
			}
			else if (Gender == "2")
			{
				btnFemale.Checked = true;
			}
			txtFName.Text = Fname;
			txtLName.Text = Lname;
			txtContact.Text = g;
			txtEmail.Text = email;
			txtDOB.Text = d;
		}

		private void btnDeleteAdvisor_Click(object sender, EventArgs e)
		{
			string connetionString;
			SqlConnection cnn;
			connetionString = @"Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True";
			cnn = new SqlConnection(connetionString);
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
			//Query to get Id...
			cnn.Open();
			string id = " ";
			string sql2 = "";
			SqlCommand command2;
			SqlDataAdapter adapter2 = new SqlDataAdapter();
			sql2 = "select Id from Advisor where Designation = '" + designation + "'and Salary = '"+txtSalary.Text+"'";
			command2 = new SqlCommand(sql2, cnn);
			SqlDataReader reader = command2.ExecuteReader();
			while (reader.Read())
			{
				int value = int.Parse(reader[0].ToString());
				id = value.ToString();
			}
			command2.Dispose();
			cnn.Close();
			//For delete data from projectAdvisor,advisor and Person table...
			cnn.Open();
			SqlCommand command1;
			SqlDataAdapter adapter1 = new SqlDataAdapter();
			string sql1 = "";
			command1 = new SqlCommand(sql1, cnn);
			sql1 = "delete from ProjectAdvisor where AdvisorId = '" + id + "'";
			command1 = new SqlCommand(sql1, cnn);
			adapter1.InsertCommand = new SqlCommand(sql1, cnn);

			SqlCommand command;
			SqlDataAdapter adapter = new SqlDataAdapter();
			string sql = "delete from Advisor where Id = '" + id + "'";
			command = new SqlCommand(sql, cnn);
			adapter.InsertCommand = new SqlCommand(sql, cnn);

			SqlCommand command3;
			SqlDataAdapter adapter3 = new SqlDataAdapter();
			string sql3 = "delete from Person where Id = '" + id + "'";
			command3 = new SqlCommand(sql3, cnn);
			adapter3.InsertCommand = new SqlCommand(sql3, cnn);
			adapter1.InsertCommand.ExecuteNonQuery();
			adapter.InsertCommand.ExecuteNonQuery();
			adapter3.InsertCommand.ExecuteNonQuery();
			MessageBox.Show("Advisor has been deleted successfully.");
			txtFName.Text = " ";
			txtLName.Text = " ";
			txtContact.Text = " ";
			txtDOB.Text = " ";
			txtEmail.Text = " ";
			txtSalary.Text = " ";
			btnFemale.Checked = false;
			btnMale.Checked = false;
			cbDesignation.Text = " ";
			command1.Dispose();
			cnn.Close();
		}
	}
}
