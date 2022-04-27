using SchoolManagementSystem.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.UserControls.ParentControls
{
	public partial class UC_ViewAttendanceToParent : UserControl
	{
		public UC_ViewAttendanceToParent()
		{
			InitializeComponent();
			dg.AutoGenerateColumns = false;
		}

		private void UC_ViewAttendanceToParent_Load(object sender, EventArgs e)
		{
			NavTitle.Text = "School Management System → Parents → View Attendance";

			Students.Items.AddRange(((Models.Parent)Engine.CurrentUser).Students.ToArray());
		}

		private void Students_SelectedIndexChanged(object sender, EventArgs e)
		{
			Student student = (Student)Students.SelectedItem;
			Classes.Items.Clear();	
			Classes.Items.AddRange(Engine.Classes.Where(c => c.Students.Contains(student)).ToArray());
		}

		private void Classes_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(Students.SelectedIndex != -1 && Classes.SelectedIndex != -1)
			{
				Student student = (Student)Students.SelectedItem;
				Class @class = (Class)Classes.SelectedItem;

				attendanceBindingSource.DataSource = Engine.GetAttendances(student.Id, @class.Id);
				attendanceBindingSource.ResetBindings(false);
			}
		}

		private void Back_Click(object sender, EventArgs e)
		{
			((ParentDashboard)ParentForm).ActivateInitials();
		}
	}
}
