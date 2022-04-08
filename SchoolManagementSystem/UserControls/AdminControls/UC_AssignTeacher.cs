using SchoolManagementSystem.UserControls.ShipmentManager;

using System;
using System.Windows.Forms;

namespace SchoolManagementSystem.UserControls.Shipment
{
	public partial class UC_AssignTeacher : UserControl
	{
		public UC_AssignTeacher()
		{
			InitializeComponent();
		}

		private void UC_AssignTeacher_Load(object sender, EventArgs e)
		{
			(this.Parent.Parent as UC_ManageTeachers).NavTitle.Text = "School Management System → Manage Teachers → Assign Teacher to Class";

			Classes.Items.AddRange(Engine.Classes.ToArray());
			Teachers.Items.AddRange(Engine.Teachers.ToArray());
		}

		private void Assign_Click(object sender, EventArgs e)
		{
			if (Classes.SelectedIndex != -1 && Teachers.SelectedIndex != -1)
			{
				Class @class = (Class)Classes.SelectedItem;
				Teacher teacher = (Teacher)Teachers.SelectedItem;
				@class.Teacher = teacher;
				@class.TeacherId = teacher.Id;

				Engine.AssignTeacher(@class.Name, teacher.Id);
				Notification.Show("Teacher assigned", Notification.Type.Success);
			}
			else
			{
				Notification.Show("Please fill in complete details", Notification.Type.Error);
			}
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (Teachers.SelectedIndex != -1)
			{
				Engine.RemoveUser(Teachers.SelectedItem as Student);
				Teachers.Items.Clear();
				Teachers.Items.AddRange(Engine.Teachers.ToArray());
				Notification.Show("Deleted", Notification.Type.Info);
				Teachers.SelectedItem = -1;
			}
		}
	}
}
