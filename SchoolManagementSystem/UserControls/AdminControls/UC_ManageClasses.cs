using SchoolManagementSystem.Forms;

using System;
using System.Windows.Forms;

namespace SchoolManagementSystem.UserControls.Inventory
{
	public partial class UC_ManageClasses : UserControl
	{
		public UC_ManageClasses()
		{
			InitializeComponent();
		}

		private void AddClass_Click(object sender, EventArgs e)
		{
			NavTitle.Text = "School Management System → Manage Classes";
		}

		private void Back_Click(object sender, EventArgs e)
		{
			(this.ParentForm as Dashboard).ActivateInitials();
		}

		private void UC_InventoryManager_Load(object sender, EventArgs e)
		{
			Classes.Items.AddRange(Engine.Classes.ToArray());
			AddClass_Click(AddClass, e);
		}

		private void Add_Click(object sender, EventArgs e)
		{
			if (ClassName.TextLength != 0)
			{
				Class cls = new Class(ClassName.Text);
				Engine.AddClass(cls);
				Classes.Items.Clear();
				Classes.Items.AddRange(Engine.Classes.ToArray());
				Notification.Show("Class added", Notification.Type.Info);
				ClassName.Clear();
				ClassName.Focus();
			}
			else
			{
				Notification.Show("Invalid class name", Notification.Type.Error);
			}
		}

		private void RemoveButton_Click(object sender, EventArgs e)
		{
			if(Classes.SelectedIndex != -1)
			{
				Engine.RemoveClass(Classes.SelectedItem as Class);
				Classes.Items.Clear();
				Classes.Items.AddRange(Engine.Classes.ToArray());
				Notification.Show("Class removed", Notification.Type.Success);
			}
		}
	}
}
