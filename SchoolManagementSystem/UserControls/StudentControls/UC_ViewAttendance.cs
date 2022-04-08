using SchoolManagementSystem.Forms;

using System;
using System.Linq;
using System.Windows.Forms;



namespace SchoolManagementSystem.UserControls.Inventory
{
	public partial class UC_ViewAttendance : UserControl
	{
		public UC_ViewAttendance()
		{
			InitializeComponent();
			dg.AutoGenerateColumns = false;
		}

		private void UC_Attendance_Load(object sender, EventArgs e)
		{
			NavTitle.Text = "School Management System → Students → Attendance";

			Classes.Items.AddRange(Engine.Classes.Where(c => c.Students.Contains(Engine.CurrentUser as Student)).Distinct().ToArray());
		}

		private void Classes_SelectedIndexChanged(object sender, EventArgs e)
		{
			Class @class = (Class)Classes.SelectedItem;

			attendanceBindingSource.DataSource = Engine.GetAttendances(Engine.CurrentUser.Id, @class.Id);
			attendanceBindingSource.ResetBindings(false);
		}

		private void Back_Click(object sender, EventArgs e)
		{
			((StudentDashboard)ParentForm).ActivateInitials();
		}
	}
}
