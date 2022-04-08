using SchoolManagementSystem.Forms;

using System;
using System.Windows.Forms;

namespace SchoolManagementSystem.UserControls.Inventory
{
	public partial class UC_ViewGrades : UserControl
	{
		public UC_ViewGrades()
		{
			InitializeComponent();
		}

		private void UC_InventoryIn_Load(object sender, EventArgs e)
		{
			NavTitle.Text = "School Management System → Students → Grades";


			gradeBindingSource.DataSource = Engine.GetGradesByStudent(Engine.CurrentUser.Id);
		}

		private void Back_Click(object sender, EventArgs e)
		{
			((StudentDashboard)ParentForm).ActivateInitials();
		}
	}
}
