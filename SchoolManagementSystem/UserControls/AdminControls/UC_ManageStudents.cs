using SchoolManagementSystem.Forms;
using SchoolManagementSystem.UserControls.AdminControls;

using System;
using System.Windows.Forms;

namespace SchoolManagementSystem.UserControls.CRM
{
	public partial class UC_ManageStudents : UserControl
	{
		public UC_ManageStudents()
		{
			InitializeComponent();
		}

		private void ActivateControl(UserControl c)
		{
			Canva.Controls.Clear();
			c.Dock = DockStyle.Fill;
			Canva.Controls.Add(c);
		}

		private void AddStudent_Click(object sender, EventArgs e)
		{
			NavTitle.Text = "School Management System → Manage Students → Add Student";
			ActivateControl(new UC_AddStudent());
		}

		private void UC_ManageStudents_Load(object sender, EventArgs e)
		{
			AddStudent_Click(this, e);
		}

		private void Back_Click(object sender, EventArgs e)
		{
			(this.ParentForm as Dashboard).ActivateInitials();
		}

		private void AssignStudentToClass_Click(object sender, EventArgs e)
		{
			NavTitle.Text = "School Management System → Manage Students → Assign Student to Class";
			ActivateControl(new UC_AssignStudent());
		}

		private void BtnManageFees_Click(object sender, EventArgs e)
		{
			NavTitle.Text = "School Management System → Manage Students → Fees";
			ActivateControl(new UC_ManageFees());
		}
	}
}
