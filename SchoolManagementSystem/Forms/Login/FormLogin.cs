using System;
using System.Linq;
using System.Windows.Forms;


namespace SchoolManagementSystem.Forms.Login
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
		}

		private bool IsValid
		{
			get
			{
				return (Username.TextLength > 0 && Password.TextLength > 0);
			}
		}

		private void Tb_TextChanged(object sender, EventArgs e)
		{
			if (IsValid) Login.Enabled = true;
			else Login.Enabled = false;
		}

		private void Login_Click(object sender, EventArgs e)
		{
			if (true)
			{
				User user = Engine.Users.FirstOrDefault(u => u.UserName == Username.Text && u.Password == Password.Text);
				if (user != null)
				{
					Engine.CurrentUser = user;
					if (user is Admin)
					{
						Dashboard dashboard = new Dashboard();
						this.Hide();
						dashboard.Show();
						Notification.Show($"Welcome Admin!", Notification.Type.Info);
					}
					else if (user is Teacher)
					{
						TeacherDashboard dashboard = new TeacherDashboard();
						this.Hide();
						dashboard.Show();
						Notification.Show($"Welcome Teacher!", Notification.Type.Info);
					}
					else if (user is Student)
					{
						StudentDashboard dashboard = new StudentDashboard();
						this.Hide();
						dashboard.Show();
						Notification.Show($"Welcome Student!", Notification.Type.Info);
					}
				}
			}
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
