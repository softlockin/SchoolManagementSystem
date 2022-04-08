using System;
using System.Windows.Forms;

namespace SchoolManagementSystem.UserControls.CRM
{
	public partial class UC_AddStudent : UserControl
	{
		ErrorProvider error = new ErrorProvider();
		public UC_AddStudent()
		{
			InitializeComponent();
		}

		private bool IsValid
		{
			get
			{
				if (StudentName.TextLength == 0)
				{
					error.SetError(StudentName, "Can't be empty"); return false;
				}
				else { error.SetError(StudentName, ""); }
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

		private void AddStudent_Click(object sender, EventArgs e)
		{
			if (IsValid)
			{
				Engine.AddUser(new Student(StudentName.Text, UserName.Text, Password.Text));
				Notification.Show("Student was added", Notification.Type.Info);
			}
		}
	}
}
