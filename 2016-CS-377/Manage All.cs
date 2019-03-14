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
	public partial class Manage_All : Form
	{
		public Manage_All()
		{
			InitializeComponent();
		}

		private void Manage_All_Load(object sender, EventArgs e)
		{

		}

		private void btnManageStudents_Click(object sender, EventArgs e)
		{
			Manage_Students s = new Manage_Students();
			s.Show();
			this.Hide();
		}
		
		private void btnManageAdvisors_Click_1(object sender, EventArgs e)
		{
			Manage_Advisors c = new Manage_Advisors();
			c.Show();
			this.Hide();
		}

		private void btnManageEvaluation_Click(object sender, EventArgs e)
		{
			Manage_Evaluation s = new Manage_Evaluation();
			s.Show();
			this.Hide();
		}

		private void btnManageProjects_Click(object sender, EventArgs e)
		{
			Manage_Project b = new Manage_Project();
			b.Show();
			this.Hide();
		}

		private void btnManageGroups_Click(object sender, EventArgs e)
		{
			Manage_Groups m = new Manage_Groups();
			m.Show();
			this.Hide();
		}

		private void btnReports_Click(object sender, EventArgs e)
		{
			Report1 b = new Report1();
			b.Show();
			this.Hide();
		}
	}
}
