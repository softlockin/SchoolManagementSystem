using SchoolManagementSystem.Forms.Login;
using SchoolManagementSystem.UserControls.Inventory;
using SchoolManagementSystem.UserControls.ParentControls;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.Forms
{
	public partial class ParentDashboard : Form
	{
		public ParentDashboard()
		{
			InitializeComponent();
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
		}

		private void Close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Maximize_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
			else this.WindowState = FormWindowState.Normal;
		}

		private void Minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		public void ActivateInitials()
		{
			Canva.Controls.Clear();
			this.WindowState = FormWindowState.Normal;
			// 
			// elInward
			// 
			this.elInward.ElipseRadius = 9;
			this.elInward.TargetControl = this.ShipmentManager;
			// 
			// ShipmentManager
			// 
			this.ShipmentManager.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ShipmentManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
			this.ShipmentManager.Controls.Add(this.pictureBox1);
			this.ShipmentManager.Controls.Add(this.label2);
			this.ShipmentManager.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ShipmentManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ShipmentManager.Location = new System.Drawing.Point(321, 210);
			this.ShipmentManager.Name = "ShipmentManager";
			this.ShipmentManager.Size = new System.Drawing.Size(148, 120);
			this.ShipmentManager.TabIndex = 4;
			this.ShipmentManager.Click += new System.EventHandler(this.Attendance_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = global::SchoolManagementSystem.Properties.Resources.icons8_shipment_logistic_48px;
			this.pictureBox1.Location = new System.Drawing.Point(37, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(74, 64);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.Attendance_Click);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(34, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "Attendance";
			this.label2.Click += new System.EventHandler(this.Attendance_Click);
			// 
			// elOutward
			// 
			this.elOutward.ElipseRadius = 9;
			this.elOutward.TargetControl = this.CRM;
			// 
			// CRM
			// 
			this.CRM.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.CRM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
			this.CRM.Controls.Add(this.label3);
			this.CRM.Controls.Add(this.pictureBox2);
			this.CRM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CRM.Location = new System.Drawing.Point(493, 210);
			this.CRM.Name = "CRM";
			this.CRM.Size = new System.Drawing.Size(148, 120);
			this.CRM.TabIndex = 5;
			this.CRM.Click += new System.EventHandler(this.Grades_Click);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(49, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 19);
			this.label3.TabIndex = 6;
			this.label3.Text = "Grades";
			this.label3.Click += new System.EventHandler(this.Grades_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = global::SchoolManagementSystem.Properties.Resources.icons8_people_64px;
			this.pictureBox2.Location = new System.Drawing.Point(35, 20);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(74, 64);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.Grades_Click);
			// 
			// Canva
			// 
			this.Canva.BackColor = System.Drawing.Color.White;
			this.Canva.Controls.Add(this.label);
			this.Canva.Controls.Add(this.CRM);
			this.Canva.Controls.Add(this.ShipmentManager);
			this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canva.Location = new System.Drawing.Point(0, 31);
			this.Canva.Name = "Canva";
			this.Canva.Size = new System.Drawing.Size(958, 528);
			this.Canva.TabIndex = 5;
			// 
			// label
			// 
			this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label.AutoSize = true;
			this.label.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label.ForeColor = System.Drawing.Color.Black;
			this.label.Location = new System.Drawing.Point(367, 173);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(221, 19);
			this.label.TabIndex = 6;
			this.label.Text = "Please select an option to proceed:";
			// 
			// bunifuElipse2
			// 
			this.bunifuElipse2.ElipseRadius = 9;
			this.bunifuElipse2.TargetControl = this;
		}

		private void ActivateControl(UserControl c)
		{
			Canva.Controls.Clear();
			c.Dock = DockStyle.Fill;
			Canva.Controls.Add(c);
		}

		public void Attendance_Click(object sender, EventArgs e)
		{
			ActivateControl(new UC_ViewAttendanceToParent());
		}

		public void Grades_Click(object sender, EventArgs e)
		{
			ActivateControl(new UC_ViewGradesToParent());
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{
			Models.Parent parent = (Models.Parent)Engine.CurrentUser;
			decimal totalFee = parent.Students.Sum(s => s.Fee);
			txtFee.Text = totalFee.ToString();
		}

		private void Logout_Click(object sender, EventArgs e)
		{
			FormLogin frm = new FormLogin();
			this.Hide();
			frm.Show();
		}
	}
}
