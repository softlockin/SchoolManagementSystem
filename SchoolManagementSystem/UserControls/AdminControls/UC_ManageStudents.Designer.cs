
namespace SchoolManagementSystem.UserControls.CRM
{
	partial class UC_ManageStudents
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Navbar = new System.Windows.Forms.Panel();
			this.NavTitle = new System.Windows.Forms.Label();
			this.MenuBar = new System.Windows.Forms.Panel();
			this.Canva = new System.Windows.Forms.Panel();
			this.BtnManageFees = new FontAwesome.Sharp.IconButton();
			this.AssignStudentToClass = new FontAwesome.Sharp.IconButton();
			this.NewEntry = new FontAwesome.Sharp.IconButton();
			this.Back = new System.Windows.Forms.PictureBox();
			this.Navbar.SuspendLayout();
			this.MenuBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
			this.SuspendLayout();
			// 
			// Navbar
			// 
			this.Navbar.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.Navbar.Controls.Add(this.Back);
			this.Navbar.Controls.Add(this.NavTitle);
			this.Navbar.Dock = System.Windows.Forms.DockStyle.Top;
			this.Navbar.Location = new System.Drawing.Point(0, 0);
			this.Navbar.Name = "Navbar";
			this.Navbar.Size = new System.Drawing.Size(958, 30);
			this.Navbar.TabIndex = 2;
			// 
			// NavTitle
			// 
			this.NavTitle.AutoSize = true;
			this.NavTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.NavTitle.ForeColor = System.Drawing.Color.Black;
			this.NavTitle.Location = new System.Drawing.Point(35, 6);
			this.NavTitle.Name = "NavTitle";
			this.NavTitle.Size = new System.Drawing.Size(117, 19);
			this.NavTitle.TabIndex = 7;
			this.NavTitle.Text = "Manage Students";
			// 
			// MenuBar
			// 
			this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.MenuBar.Controls.Add(this.BtnManageFees);
			this.MenuBar.Controls.Add(this.AssignStudentToClass);
			this.MenuBar.Controls.Add(this.NewEntry);
			this.MenuBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.MenuBar.Location = new System.Drawing.Point(0, 30);
			this.MenuBar.Name = "MenuBar";
			this.MenuBar.Size = new System.Drawing.Size(157, 498);
			this.MenuBar.TabIndex = 3;
			// 
			// Canva
			// 
			this.Canva.BackColor = System.Drawing.Color.White;
			this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canva.Location = new System.Drawing.Point(157, 30);
			this.Canva.Name = "Canva";
			this.Canva.Size = new System.Drawing.Size(801, 498);
			this.Canva.TabIndex = 4;
			// 
			// BtnManageFees
			// 
			this.BtnManageFees.Dock = System.Windows.Forms.DockStyle.Top;
			this.BtnManageFees.FlatAppearance.BorderSize = 0;
			this.BtnManageFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnManageFees.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnManageFees.ForeColor = System.Drawing.Color.White;
			this.BtnManageFees.IconChar = FontAwesome.Sharp.IconChar.None;
			this.BtnManageFees.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnManageFees.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.BtnManageFees.IconSize = 30;
			this.BtnManageFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnManageFees.Location = new System.Drawing.Point(0, 74);
			this.BtnManageFees.Name = "BtnManageFees";
			this.BtnManageFees.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.BtnManageFees.Size = new System.Drawing.Size(157, 37);
			this.BtnManageFees.TabIndex = 21;
			this.BtnManageFees.Text = "Manage Fees";
			this.BtnManageFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnManageFees.UseVisualStyleBackColor = true;
			this.BtnManageFees.Click += new System.EventHandler(this.BtnManageFees_Click);
			// 
			// AssignStudentToClass
			// 
			this.AssignStudentToClass.Dock = System.Windows.Forms.DockStyle.Top;
			this.AssignStudentToClass.FlatAppearance.BorderSize = 0;
			this.AssignStudentToClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AssignStudentToClass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AssignStudentToClass.ForeColor = System.Drawing.Color.White;
			this.AssignStudentToClass.IconChar = FontAwesome.Sharp.IconChar.None;
			this.AssignStudentToClass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.AssignStudentToClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.AssignStudentToClass.IconSize = 30;
			this.AssignStudentToClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AssignStudentToClass.Location = new System.Drawing.Point(0, 37);
			this.AssignStudentToClass.Name = "AssignStudentToClass";
			this.AssignStudentToClass.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.AssignStudentToClass.Size = new System.Drawing.Size(157, 37);
			this.AssignStudentToClass.TabIndex = 20;
			this.AssignStudentToClass.Text = "Assign Class";
			this.AssignStudentToClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AssignStudentToClass.UseVisualStyleBackColor = true;
			this.AssignStudentToClass.Click += new System.EventHandler(this.AssignStudentToClass_Click);
			// 
			// NewEntry
			// 
			this.NewEntry.Dock = System.Windows.Forms.DockStyle.Top;
			this.NewEntry.FlatAppearance.BorderSize = 0;
			this.NewEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.NewEntry.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NewEntry.ForeColor = System.Drawing.Color.White;
			this.NewEntry.IconChar = FontAwesome.Sharp.IconChar.None;
			this.NewEntry.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.NewEntry.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.NewEntry.IconSize = 30;
			this.NewEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.NewEntry.Location = new System.Drawing.Point(0, 0);
			this.NewEntry.Name = "NewEntry";
			this.NewEntry.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.NewEntry.Size = new System.Drawing.Size(157, 37);
			this.NewEntry.TabIndex = 19;
			this.NewEntry.Text = "Add Student";
			this.NewEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.NewEntry.UseVisualStyleBackColor = true;
			this.NewEntry.Click += new System.EventHandler(this.AddStudent_Click);
			// 
			// Back
			// 
			this.Back.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Back.Dock = System.Windows.Forms.DockStyle.Left;
			this.Back.Image = global::SchoolManagementSystem.Properties.Resources.back;
			this.Back.Location = new System.Drawing.Point(0, 0);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(30, 30);
			this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Back.TabIndex = 8;
			this.Back.TabStop = false;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// UC_ManageStudents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Canva);
			this.Controls.Add(this.MenuBar);
			this.Controls.Add(this.Navbar);
			this.Name = "UC_ManageStudents";
			this.Size = new System.Drawing.Size(958, 528);
			this.Load += new System.EventHandler(this.UC_ManageStudents_Load);
			this.Navbar.ResumeLayout(false);
			this.Navbar.PerformLayout();
			this.MenuBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Navbar;
		private System.Windows.Forms.PictureBox Back;
		public System.Windows.Forms.Label NavTitle;
		private System.Windows.Forms.Panel MenuBar;
		private FontAwesome.Sharp.IconButton NewEntry;
		private System.Windows.Forms.Panel Canva;
		private FontAwesome.Sharp.IconButton AssignStudentToClass;
		private FontAwesome.Sharp.IconButton BtnManageFees;
	}
}
