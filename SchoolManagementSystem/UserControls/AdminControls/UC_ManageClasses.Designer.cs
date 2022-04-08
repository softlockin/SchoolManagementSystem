
namespace SchoolManagementSystem.UserControls.Inventory
{
	partial class UC_ManageClasses
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
			this.components = new System.ComponentModel.Container();
			this.Navbar = new System.Windows.Forms.Panel();
			this.Back = new System.Windows.Forms.PictureBox();
			this.NavTitle = new System.Windows.Forms.Label();
			this.MenuBar = new System.Windows.Forms.Panel();
			this.AddClass = new FontAwesome.Sharp.IconButton();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Canva = new System.Windows.Forms.Panel();
			this.Classes = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.RemoveButton = new FontAwesome.Sharp.IconButton();
			this.label3 = new System.Windows.Forms.Label();
			this.Add = new FontAwesome.Sharp.IconButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ClassName = new System.Windows.Forms.TextBox();
			this.Navbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
			this.MenuBar.SuspendLayout();
			this.Canva.SuspendLayout();
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
			this.Navbar.TabIndex = 1;
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
			this.toolTip1.SetToolTip(this.Back, "Back to Main Page");
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// NavTitle
			// 
			this.NavTitle.AutoSize = true;
			this.NavTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.NavTitle.ForeColor = System.Drawing.Color.Black;
			this.NavTitle.Location = new System.Drawing.Point(35, 6);
			this.NavTitle.Name = "NavTitle";
			this.NavTitle.Size = new System.Drawing.Size(183, 19);
			this.NavTitle.TabIndex = 7;
			this.NavTitle.Text = "School Management System";
			// 
			// MenuBar
			// 
			this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.MenuBar.Controls.Add(this.AddClass);
			this.MenuBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.MenuBar.Location = new System.Drawing.Point(0, 30);
			this.MenuBar.Name = "MenuBar";
			this.MenuBar.Size = new System.Drawing.Size(157, 498);
			this.MenuBar.TabIndex = 2;
			// 
			// AddClass
			// 
			this.AddClass.Dock = System.Windows.Forms.DockStyle.Top;
			this.AddClass.FlatAppearance.BorderSize = 0;
			this.AddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddClass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddClass.ForeColor = System.Drawing.Color.White;
			this.AddClass.IconChar = FontAwesome.Sharp.IconChar.None;
			this.AddClass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.AddClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.AddClass.IconSize = 30;
			this.AddClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AddClass.Location = new System.Drawing.Point(0, 0);
			this.AddClass.Name = "AddClass";
			this.AddClass.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.AddClass.Size = new System.Drawing.Size(157, 37);
			this.AddClass.TabIndex = 19;
			this.AddClass.Text = "Add/Remove";
			this.AddClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AddClass.UseVisualStyleBackColor = true;
			this.AddClass.Click += new System.EventHandler(this.AddClass_Click);
			// 
			// Canva
			// 
			this.Canva.Controls.Add(this.Classes);
			this.Canva.Controls.Add(this.label2);
			this.Canva.Controls.Add(this.RemoveButton);
			this.Canva.Controls.Add(this.label3);
			this.Canva.Controls.Add(this.Add);
			this.Canva.Controls.Add(this.label1);
			this.Canva.Controls.Add(this.label4);
			this.Canva.Controls.Add(this.ClassName);
			this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canva.Location = new System.Drawing.Point(157, 30);
			this.Canva.Name = "Canva";
			this.Canva.Size = new System.Drawing.Size(801, 498);
			this.Canva.TabIndex = 3;
			// 
			// Classes
			// 
			this.Classes.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.Classes.FormattingEnabled = true;
			this.Classes.Location = new System.Drawing.Point(251, 314);
			this.Classes.Name = "Classes";
			this.Classes.Size = new System.Drawing.Size(286, 23);
			this.Classes.TabIndex = 45;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(248, 296);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 15);
			this.label2.TabIndex = 44;
			this.label2.Text = "Select Class:";
			// 
			// RemoveButton
			// 
			this.RemoveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.RemoveButton.FlatAppearance.BorderSize = 0;
			this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RemoveButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RemoveButton.ForeColor = System.Drawing.Color.White;
			this.RemoveButton.IconChar = FontAwesome.Sharp.IconChar.None;
			this.RemoveButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.RemoveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.RemoveButton.IconSize = 30;
			this.RemoveButton.Location = new System.Drawing.Point(251, 354);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.RemoveButton.Size = new System.Drawing.Size(286, 31);
			this.RemoveButton.TabIndex = 40;
			this.RemoveButton.Text = "Remove";
			this.RemoveButton.UseVisualStyleBackColor = false;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(338, 246);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 20);
			this.label3.TabIndex = 38;
			this.label3.Text = "Remove Class";
			// 
			// Add
			// 
			this.Add.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.Add.FlatAppearance.BorderSize = 0;
			this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Add.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Add.ForeColor = System.Drawing.Color.White;
			this.Add.IconChar = FontAwesome.Sharp.IconChar.None;
			this.Add.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.Add.IconSize = 30;
			this.Add.Location = new System.Drawing.Point(251, 155);
			this.Add.Name = "Add";
			this.Add.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.Add.Size = new System.Drawing.Size(286, 31);
			this.Add.TabIndex = 36;
			this.Add.Text = "Add";
			this.Add.UseVisualStyleBackColor = false;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(254, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 15);
			this.label1.TabIndex = 31;
			this.label1.Text = "Name";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(338, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 20);
			this.label4.TabIndex = 30;
			this.label4.Text = "Add Class";
			// 
			// ClassName
			// 
			this.ClassName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.ClassName.Location = new System.Drawing.Point(251, 114);
			this.ClassName.Name = "ClassName";
			this.ClassName.Size = new System.Drawing.Size(286, 23);
			this.ClassName.TabIndex = 29;
			// 
			// UC_ManageClasses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.Canva);
			this.Controls.Add(this.MenuBar);
			this.Controls.Add(this.Navbar);
			this.Name = "UC_ManageClasses";
			this.Size = new System.Drawing.Size(958, 528);
			this.Load += new System.EventHandler(this.UC_InventoryManager_Load);
			this.Navbar.ResumeLayout(false);
			this.Navbar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
			this.MenuBar.ResumeLayout(false);
			this.Canva.ResumeLayout(false);
			this.Canva.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Navbar;
		private System.Windows.Forms.PictureBox Back;
		private System.Windows.Forms.Panel MenuBar;
		private FontAwesome.Sharp.IconButton AddClass;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Panel Canva;
		public System.Windows.Forms.Label NavTitle;
		private FontAwesome.Sharp.IconButton Add;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox ClassName;
		private FontAwesome.Sharp.IconButton RemoveButton;
		public System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox Classes;
		public System.Windows.Forms.Label label2;
	}
}
