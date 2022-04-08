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
	public partial class UC_ManageFees : UserControl
	{
		public UC_ManageFees()
		{
			InitializeComponent();
		}

		private void UC_ManageFees_Load(object sender, EventArgs e)
		{
			Students.Items.AddRange(Engine.Students.ToArray());
		}

		private void Assign_Click(object sender, EventArgs e)
		{
			if (Students.SelectedIndex != -1)
			{
				Engine.AssignFee(((Student)Students.SelectedItem).Id, Amount.Value);
				Notification.Show("Fee assigned", Notification.Type.Success);
			}
			else
				Notification.Show("Please select a student", Notification.Type.Error);
		}
	}
}
