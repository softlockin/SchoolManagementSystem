using System;
using System.Linq;
using System.Windows.Forms;



namespace SchoolManagementSystem.UserControls.CRM
{
	public partial class UC_AssignStudent : UserControl
	{
		public UC_AssignStudent()
		{
			InitializeComponent();
		}

		private void Assign_Click(object sender, EventArgs e)
		{
			if (Students.SelectedIndex != -1 && Classes.SelectedIndex != -1)
			{
				Student student = Students.SelectedItem as Student;
				Class @class = Classes.SelectedItem as Class;

				Engine.AssignStudent(@class.Name, student.Id);
				Notification.Show("Student assigned", Notification.Type.Success);
			}
		}

		private void UC_AssignStudent_Load(object sender, EventArgs e)
		{
			Students.Items.AddRange(Engine.Students.ToArray());
			Classes.Items.AddRange(Engine.Classes.ToArray());
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if(Students.SelectedIndex != -1)
			{
				Engine.RemoveUser(Students.SelectedItem as Student);
				Students.Items.Clear();
				Students.Items.AddRange(Engine.Students.ToArray());
				Notification.Show("Deleted", Notification.Type.Info);
				Students.SelectedItem = -1;
			}
		}
	}
}
