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
	public partial class UC_ViewGradesToParent : UserControl
	{
		public UC_ViewGradesToParent()
		{
			InitializeComponent();
		}

		private void UC_ViewGradesToParent_Load(object sender, EventArgs e)
		{
			NavTitle.Text = "School Management System → Parents → View Grades";

			Students.Items.AddRange(((Models.Parent)Engine.CurrentUser).Students.ToArray());
		}

		private void Students_SelectedIndexChanged(object sender, EventArgs e)
		{
			Student student = (Student)Students.SelectedItem;

			var source = Engine.GetGradesByStudent(student.Id);
			gradeBindingSource.DataSource = source;
		}

		private void dg_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim().Equals("F") || dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim().Equals("E"))
				e.CellStyle.BackColor = Color.Red;
			else if (dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim().Equals("C") || dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim().Equals("D"))
				e.CellStyle.BackColor = Color.Orange;
			else if (dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim().Equals("A") || dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim().Equals("B"))
				e.CellStyle.BackColor = Color.Green;

			dg.ClearSelection();
		}

		private void Back_Click(object sender, EventArgs e)
		{
			((ParentDashboard)ParentForm).ActivateInitials();
		}
	}
}
