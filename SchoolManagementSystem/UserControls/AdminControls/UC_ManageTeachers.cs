using SchoolManagementSystem.Forms;
using SchoolManagementSystem.UserControls.Shipment;

using System;
using System.Windows.Forms;

namespace SchoolManagementSystem.UserControls.ShipmentManager
{
	public partial class UC_ManageTeachers : UserControl
	{
		public UC_ManageTeachers()
		{
			InitializeComponent();
		}

		private void ActivateControl(UserControl c)
		{
			Canva.Controls.Clear();
			c.Dock = DockStyle.Fill;
			Canva.Controls.Add(c);
		}

		private void Back_Click(object sender, EventArgs e)
		{
			(this.ParentForm as Dashboard).ActivateInitials();
		}

		private void AddTeacher_Click(object sender, EventArgs e)
		{
			ActivateControl(new UC_AddTeacher());
		}

		private void AssignToClass_Click(object sender, EventArgs e)
		{
			ActivateControl(new UC_AssignTeacher());
		}

		private void UC_ShipmentManager_Load(object sender, EventArgs e)
		{
			AddTeacher_Click(AddTeacher, e);
		}
	}
}
