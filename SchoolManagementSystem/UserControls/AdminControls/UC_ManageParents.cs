using SchoolManagementSystem.Forms;
using SchoolManagementSystem.UserControls.Shipment;
using SchoolManagementSystem.UserControls.ShipmentManager;

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
	public partial class UC_ManageParents : UserControl
	{
		public UC_ManageParents()
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

		private void AddParent_Click(object sender, EventArgs e)
		{
			NavTitle.Text = "School Management System → Manage Parents → Add Parent";
			ActivateControl(new UC_AddParent());
		}

		private void AssignToStudent_Click(object sender, EventArgs e)
		{
			NavTitle.Text = "School Management System → Manage Parents → Assign Student to Parent";
			ActivateControl(new UC_AssignParentToStudent());
		}

		private void UC_ManageParents_Load(object sender, EventArgs e)
		{
			AddParent_Click(AddTeacher, e);
		}
	}
}
