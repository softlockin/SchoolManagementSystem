using System;
using System.Windows.Forms;

namespace SchoolManagementSystem.UserControls.ShipmentManager
{
	public partial class UC_AddTeacher : UserControl
	{
		ErrorProvider error = new ErrorProvider();

		public UC_AddTeacher()
		{
			InitializeComponent();
		}

		private bool IsValid
		{
			get
			{
				if (TeacherName.TextLength == 0)
				{
					error.SetError(TeacherName, "Can't be empty"); return false;
				}
				else { error.SetError(TeacherName, ""); }
				if (UserName.TextLength == 0)
				{
					error.SetError(UserName, "Can't be empty"); return false;
				}
				else { error.SetError(UserName, ""); }
				if (Password.TextLength == 0)
				{
					error.SetError(Password, "Can't be empty"); return false;
				}
				else { error.SetError(Password, ""); }
				return true;
			}
		}

		private void UC_InwardShipments_Load(object sender, EventArgs e)
		{
			(this.Parent.Parent as UC_ManageTeachers).NavTitle.Text = "School Management System → Manage Teachers → Add teacher";
		}

		private void AddStudent_Click(object sender, EventArgs e)
		{
			if (IsValid)
			{
				Engine.AddUser(new Teacher(TeacherName.Text, UserName.Text, Password.Text));
				Notification.Show("Teacher was added", Notification.Type.Success);
			}
		}
	}
}
