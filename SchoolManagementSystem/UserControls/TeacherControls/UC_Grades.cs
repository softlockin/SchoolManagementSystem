using SchoolManagementSystem.Forms;

using System;
using System.Linq;
using System.Windows.Forms;

namespace SchoolManagementSystem.UserControls.Inventory
{
	public partial class UC_Grades : UserControl
	{
		public UC_Grades()
		{
			InitializeComponent();
		}

		private bool IsValid
		{
			get
			{
				return true;
			}
		}

		private void UC_Grades_Load(object sender, EventArgs e)
		{
			NavTitle.Text = "School Management System → Teachers → Grades";

			Classes.Items.AddRange(Engine.Classes.Where(c => c.TeacherId == Engine.CurrentUser.Id).ToArray());

			gradeBindingSource.DataSource = Engine.Grades;
		}

		private void Save_Click(object sender, EventArgs e)
		{
			try
			{
				if (IsValid)
				{
					Student student = (Student)Students.SelectedItem;
					Class @class = (Class)Classes.SelectedItem;

					Engine.AssignGrade(student.Id, @class.Id, Grades.Text);
					Notification.Show("Grade saved", Notification.Type.Success);

					gradeBindingSource.DataSource = Engine.GetGradesByClass(@class.Id);
					gradeBindingSource.ResetBindings(false);
				}
			}
			catch (Exception)
			{
				//MessageBox.Show($"Could not due to:\nException type: {ex.GetType()}\nMessage: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Classes_SelectedIndexChanged(object sender, EventArgs e)
		{
			Class @class = (Class)Classes.SelectedItem;
			Students.Items.Clear();
			Students.Items.AddRange(@class.Students.ToArray());

			gradeBindingSource.DataSource = Engine.GetGradesByClass(@class.Id);
		}

		private void Back_Click(object sender, EventArgs e)
		{
			((TeacherDashboard)ParentForm).ActivateInitials();
		}
	}
}
