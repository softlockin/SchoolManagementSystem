using SchoolManagementSystem.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.UserControls.AdminControls
{
	public partial class UC_AssignParentToStudent : UserControl
	{
		public UC_AssignParentToStudent()
		{
			InitializeComponent();
		}

		private void UC_AssignParentToStudent_Load(object sender, EventArgs e)
		{
			Students.Items.AddRange(Engine.Students.ToArray());
			Parents.Items.AddRange(Engine.Parents.ToArray());
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (Parents.SelectedIndex != -1)
			{
				Engine.RemoveUser(Parents.SelectedItem as Parent);
				Parents.Items.Clear();
				Parents.Items.AddRange(Engine.Students.ToArray());
				Notification.Show("Deleted", Notification.Type.Info);
				Parents.SelectedItem = -1;
			}
		}

		private void RemoveStudentFromClass_Click(object sender, EventArgs e)
		{
			if (Students.SelectedIndex != -1 && Parents.SelectedIndex != -1)
			{
				Student student = Students.SelectedItem as Student;
				Parent parent = Parents.SelectedItem as Parent;

				Engine.RemoveStudentFromParent(parent.Id, student.Id);
				Notification.Show("Removed", Notification.Type.Success);
			}
		}

		private void Assign_Click(object sender, EventArgs e)
		{
			if (Students.SelectedIndex != -1 && Parents.SelectedIndex != -1)
			{
				Student student = Students.SelectedItem as Student;
				Parent @class = Parents.SelectedItem as Parent;

				Engine.AssignStudentToParent(@class.Id, student.Id);
				Notification.Show("Parent assigned", Notification.Type.Success);
			}
		}
	}
}
