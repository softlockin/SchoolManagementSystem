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
	public partial class UC_AddParent : UserControl
	{
		ErrorProvider error = new ErrorProvider();

		public UC_AddParent()
		{
			InitializeComponent();
		}

		private bool IsValid
		{
			get
			{
				if (ParentName.TextLength == 0)
				{
					error.SetError(ParentName, "Can't be empty"); return false;
				}
				else { error.SetError(ParentName, ""); }
				if (UserName.TextLength == 0)
				{
					error.SetError(UserName, "Can't be empty"); return false;
				}
				else { error.SetError(UserName, ""); }
				if (Password.TextLength == 0)
				{
					error.SetError(Password, "Can't be empty"); return false;
				}
				else { error.SetError(Password, ""); }
				return true;
			}
		}

		private void AddParent_Click(object sender, EventArgs e)
		{
			if (IsValid)
			{
				Engine.AddUser(new Parent(ParentName.Text, UserName.Text, Password.Text));
				Notification.Show("Parent was added", Notification.Type.Success);
			}
		}
	}
}
