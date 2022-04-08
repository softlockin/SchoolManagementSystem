using SchoolManagementSystem.Forms;

using System;
using System.Linq;
using System.Windows.Forms;


namespace SchoolManagementSystem.UserControls.Inventory
{
	public partial class UC_Attendance : UserControl
	{
		public UC_Attendance()
		{
			InitializeComponent();
			dg.AutoGenerateColumns = false;
		}

		private void UC_Attendance_Load(object sender, EventArgs e)
		{
			NavTitle.Text = "School Management System → Teachers → Attendance";

			Classes.Items.AddRange(Engine.Classes.Where(c => c.TeacherId == Engine.CurrentUser.Id).ToArray());
		}

		private void Classes_SelectedIndexChanged(object sender, EventArgs e)
		{
			Class @class = (Class)Classes.SelectedItem;
			Student[] students = Engine.Classes.Where(c => c.Name == @class.Name && c.Teacher.Id == Engine.CurrentUser.Id).First().Students.ToArray();

			Attendance[] models = new Attendance[students.Length];
			for (int i = 0; i < students.Length; i++)
			{
				models[i] = new Attendance() { Student = students[i], IsPresent = false, Date = Date.Value };
			}

			dg.DataSource = null;
			attendanceBindingSource.DataSource = models;
			dg.DataSource = attendanceBindingSource;
		}

		private void Save_Click(object sender, EventArgs e)
		{
			Class @class = (Class)Classes.SelectedItem;

			var models = attendanceBindingSource.List;

			foreach (var model in models.OfType<Attendance>())
			{
				Student student = Engine.Students.FirstOrDefault(c => c.Id == model.Student.Id);

				Engine.MarkAttendance(student.Id, @class.Id, model.IsPresent, Date.Value);
			}

			Notification.Show("Attendance saved", Notification.Type.Info);
		}

		private void Back_Click(object sender, EventArgs e)
		{
			((TeacherDashboard)ParentForm).ActivateInitials();
		}

		private void dg_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (dg.CurrentCell is System.Windows.Forms.DataGridViewCheckBoxCell ||

dg.CurrentCell is System.Windows.Forms.DataGridViewComboBoxCell)

			{

				dg.CommitEdit(DataGridViewDataErrorContexts.Commit);

			}
		}
	}
}
