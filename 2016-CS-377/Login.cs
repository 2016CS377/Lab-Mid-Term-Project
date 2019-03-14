using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (txtUsername.Text == "admin" && txtPassword.Text == "123")
			{
				Manage_All m = new Manage_All();
				m.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Please enter the assigned Password and Username...");
			}
		}

		private void Login_Load(object sender, EventArgs e)
		{
			txtUsername.Text = "admin";
			txtPassword.Text = "123";
		}
	}
}
