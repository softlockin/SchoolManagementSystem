namespace SchoolManagementSystem.UserControls.AdminControls
{
	partial class UC_ManageParents
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
			this.Canva = new System.Windows.Forms.Panel();
			this.MenuBar = new System.Windows.Forms.Panel();
			this.Back = new System.Windows.Forms.PictureBox();
			this.AssignToClass = new FontAwesome.Sharp.IconButton();
			this.AddTeacher = new FontAwesome.Sharp.IconButton();
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
			this.Navbar.Location = new System.Drawing.Point(157, 0);
			this.Navbar.Name = "Navbar";
			this.Navbar.Size = new System.Drawing.Size(801, 30);
			this.Navbar.TabIndex = 13;
			// 
			// NavTitle
			// 
			this.NavTitle.AutoSize = true;
			this.NavTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.NavTitle.ForeColor = System.Drawing.Color.Black;
			this.NavTitle.Location = new System.Drawing.Point(34, 6);
			this.NavTitle.Name = "NavTitle";
			this.NavTitle.Size = new System.Drawing.Size(109, 19);
			this.NavTitle.TabIndex = 7;
			this.NavTitle.Text = "Manage Parents";
			// 
			// Canva
			// 
			this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canva.Location = new System.Drawing.Point(157, 0);
			this.Canva.Name = "Canva";
			this.Canva.Size = new System.Drawing.Size(801, 528);
			this.Canva.TabIndex = 15;
			// 
			// MenuBar
			// 
			this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.MenuBar.Controls.Add(this.AssignToClass);
			this.MenuBar.Controls.Add(this.AddTeacher);
			this.MenuBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.MenuBar.Location = new System.Drawing.Point(0, 0);
			this.MenuBar.Name = "MenuBar";
			this.MenuBar.Size = new System.Drawing.Size(157, 528);
			this.MenuBar.TabIndex = 14;
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
			// AssignToClass
			// 
			this.AssignToClass.Dock = System.Windows.Forms.DockStyle.Top;
			this.AssignToClass.FlatAppearance.BorderSize = 0;
			this.AssignToClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AssignToClass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AssignToClass.ForeColor = System.Drawing.Color.White;
			this.AssignToClass.IconChar = FontAwesome.Sharp.IconChar.None;
			this.AssignToClass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.AssignToClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.AssignToClass.IconSize = 30;
			this.AssignToClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AssignToClass.Location = new System.Drawing.Point(0, 37);
			this.AssignToClass.Name = "AssignToClass";
			this.AssignToClass.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.AssignToClass.Size = new System.Drawing.Size(157, 37);
			this.AssignToClass.TabIndex = 20;
			this.AssignToClass.Text = "Assign to Student";
			this.AssignToClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AssignToClass.UseVisualStyleBackColor = true;
			this.AssignToClass.Click += new System.EventHandler(this.AssignToStudent_Click);
			// 
			// AddTeacher
			// 
			this.AddTeacher.Dock = System.Windows.Forms.DockStyle.Top;
			this.AddTeacher.FlatAppearance.BorderSize = 0;
			this.AddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddTeacher.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddTeacher.ForeColor = System.Drawing.Color.White;
			this.AddTeacher.IconChar = FontAwesome.Sharp.IconChar.None;
			this.AddTeacher.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.AddTeacher.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.AddTeacher.IconSize = 30;
			this.AddTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AddTeacher.Location = new System.Drawing.Point(0, 0);
			this.AddTeacher.Name = "AddTeacher";
			this.AddTeacher.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.AddTeacher.Size = new System.Drawing.Size(157, 37);
			this.AddTeacher.TabIndex = 19;
			this.AddTeacher.Text = "Add Parent";
			this.AddTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AddTeacher.UseVisualStyleBackColor = true;
			this.AddTeacher.Click += new System.EventHandler(this.AddParent_Click);
			// 
			// UC_ManageParents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Navbar);
			this.Controls.Add(this.Canva);
			this.Controls.Add(this.MenuBar);
			this.Name = "UC_ManageParents";
			this.Size = new System.Drawing.Size(958, 528);
			this.Load += new System.EventHandler(this.UC_ManageParents_Load);
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
		private System.Windows.Forms.Panel Canva;
		private System.Windows.Forms.Panel MenuBar;
		private FontAwesome.Sharp.IconButton AssignToClass;
		private FontAwesome.Sharp.IconButton AddTeacher;
	}
}
