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
	public partial class Manage_Students : Form
	{
		SqlConnection cnn  = new SqlConnection("Data Source=DESKTOP-KM5HNLG;Initial Catalog=ProjectA;Integrated Security=True");

		public Manage_Students()
		{
			InitializeComponent();
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

		private void btnAddStudent_Click(object sender, EventArgs e)
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
			sql = "insert into  Person (FirstName,LastName,Contact,Email,DateOfBirth,Gender) values('"+txtFName.Text+"','"+txtLName.Text+"','"+txtContact.Text+"','"+txtEmail.Text+"','"+txtDOB.Text+"','"+gender+"')";
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
			//For addind data in student table...
			cnn.Open();
			SqlCommand command1;
			SqlDataAdapter adapter1 = new SqlDataAdapter();
			string sql1 = "";
			command1 = new SqlCommand(sql1,cnn);
			sql1 = "insert into  Student (Id,RegistrationNo) values('" + id + "','" + txtRegNo.Text + "')";
			command = new SqlCommand(sql1, cnn);
			adapter1.InsertCommand = new SqlCommand(sql1, cnn);
			adapter1.InsertCommand.ExecuteNonQuery();
			MessageBox.Show("Student has been added successfully.");
			txtFName.Text = " ";
			txtLName.Text = " ";
			txtContact.Text = " ";
			txtDOB.Text = " ";
			txtEmail.Text = " ";
			txtRegNo.Text = " ";
			btnFemale.Checked = false;
			btnMale.Checked = false;
			command.Dispose();
			cnn.Close();

		}

		private void btnUpdateStudent_Click(object sender, EventArgs e)
		{
			
			//MessageBox.Show("Write Registration No first to UPDATE DATA");
			

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
			sql2 = "select Id from Student where RegistrationNo = '"+txtRegNo.Text+"'";
			command2 = new SqlCommand(sql2, cnn);
			SqlDataReader reader = command2.ExecuteReader();
			while (reader.Read())
			{
				int value = int.Parse(reader[0].ToString());
				id = value.ToString();
			}
			command2.Dispose();
			cnn.Close();

			
			//updating values in Person table...
			
			string sql = "";
			try
			{
				cnn.Open();
				SqlCommand command;
				SqlDataAdapter adapter = new SqlDataAdapter();
				sql = "update Person set FirstName = '" + txtFName.Text + "',LastName = '" + txtLName.Text + "',Contact = '" + txtContact.Text + "',Email = '" + txtEmail.Text + "',DateOfBirth = '" + Convert.ToDateTime(txtDOB.Text) + "',Gender = '" + gender + "' where Id = '" + id + "'";
				command = new SqlCommand(sql, cnn);
				adapter.InsertCommand = new SqlCommand(sql, cnn);
				adapter.InsertCommand.ExecuteNonQuery();
				command.Dispose();
				cnn.Close();
			}
			catch(Exception)
			{
				MessageBox.Show("Please Enter Valid date");
			}


			cnn.Close();
			cnn.Close();
			cnn.Close();
			cnn.Close();
			//For updating data in student table...
			cnn.Open();
			SqlCommand command1;
			SqlDataAdapter adapter1 = new SqlDataAdapter();
			string sql1 = "";
			command1 = new SqlCommand(sql1, cnn);
			sql1 = "update Student set RegistrationNo = '"+txtRegNo.Text+"' where Id = '"+id+"'";
			command1 = new SqlCommand(sql1, cnn);
			adapter1.InsertCommand = new SqlCommand(sql1, cnn);
			adapter1.InsertCommand.ExecuteNonQuery();
			MessageBox.Show("Student has been Updated successfully.");
			txtFName.Text = " ";
			txtLName.Text = " ";
			txtContact.Text = " ";
			txtDOB.Text = " ";
			txtEmail.Text = " ";
			txtRegNo.Text = " ";
			btnFemale.Checked = false;
			btnMale.Checked = false;
			command1.Dispose();
			cnn.Close();

		}

		private void lblExtractData_Click(object sender, EventArgs e)
		{

			//getting data against student id..
			cnn.Open();
			string id = " ";
			string sql2 = "";
			SqlCommand command2;
			SqlDataAdapter adapter2 = new SqlDataAdapter();
			sql2 = "select Id from Student where RegistrationNo = '" + txtRegNo.Text + "'";
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

			//getting contact against student registration no....
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




			if (int.Parse(Gender) == 1)
			{
				btnMale.Checked = true;
			}
			else if (int.Parse(Gender) == 2)
			{
				btnFemale.Checked = true;
			}
			txtFName.Text = Fname;
			txtLName.Text = Lname;
			txtContact.Text = g;
			txtEmail.Text = email;
			txtDOB.Text = d;
		}

		private void btnDeleteStudent_Click(object sender, EventArgs e)
		{
			//Query to get Id...
			cnn.Open();
			string id = " ";
			string sql2 = "";
			SqlCommand command2;
			SqlDataAdapter adapter2 = new SqlDataAdapter();
			sql2 = "select Id from Student where RegistrationNo = '" + txtRegNo.Text + "'";
			command2 = new SqlCommand(sql2, cnn);
			SqlDataReader reader = command2.ExecuteReader();
			while (reader.Read())
			{
				int value = int.Parse(reader[0].ToString());
				id = value.ToString();
			}
			command2.Dispose();
			cnn.Close();
			//For delete data from groupstudent,student and Person table...
			cnn.Open();
			SqlCommand command1;
			SqlDataAdapter adapter1 = new SqlDataAdapter();
			string sql1 = "";
			command1 = new SqlCommand(sql1, cnn);
			sql1 = "delete from GroupStudent where StudentId = '" + id+"'";
			command1 = new SqlCommand(sql1, cnn);
			adapter1.InsertCommand = new SqlCommand(sql1, cnn);
			
			SqlCommand command;
			SqlDataAdapter adapter = new SqlDataAdapter();
			string sql = "delete from Student where Id = '" + id + "'";
			command = new SqlCommand(sql, cnn);
			adapter.InsertCommand = new SqlCommand(sql, cnn);
			
			SqlCommand command3;
			SqlDataAdapter adapter3 = new SqlDataAdapter();
			string sql3 = "delete from Person where Id = '" + id + "'";
			command3 = new SqlCommand(sql3,cnn);
			adapter3.InsertCommand = new SqlCommand(sql3,cnn);
			adapter1.InsertCommand.ExecuteNonQuery();
			adapter.InsertCommand.ExecuteNonQuery();
			adapter3.InsertCommand.ExecuteNonQuery();

			//adapter.InsertCommand.ExecuteNonQuery();
			MessageBox.Show("Student has been deleted successfully.");
			txtFName.Text = " ";
			txtLName.Text = " ";
			txtContact.Text = " ";
			txtDOB.Text = " ";
			txtEmail.Text = " ";
			txtRegNo.Text = " ";
			btnFemale.Checked = false;
			btnMale.Checked = false;
			command1.Dispose();
			cnn.Close();
		}

		private void Manage_Students_Load(object sender, EventArgs e)
		{

		}
	}
}
