﻿using SchoolManagementSystem.Forms;

using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace SchoolManagementSystem.UserControls.Inventory
{
	public partial class UC_ViewGrades : UserControl
	{
		public UC_ViewGrades()
		{
			InitializeComponent();
		}

		private void UC_InventoryIn_Load(object sender, EventArgs e)
		{
			NavTitle.Text = "School Management System → Students → Grades";

			var source = Engine.GetGradesByStudent(Engine.CurrentUser.Id);
			gradeBindingSource.DataSource = source;
		}

		private void Back_Click(object sender, EventArgs e)
		{
			((StudentDashboard)ParentForm).ActivateInitials();
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
	}
}
