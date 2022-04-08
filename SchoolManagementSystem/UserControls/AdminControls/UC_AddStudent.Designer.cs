
namespace SchoolManagementSystem.UserControls.CRM
{
	partial class UC_AddStudent
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
			this.label5 = new System.Windows.Forms.Label();
			this.AddStudent = new FontAwesome.Sharp.IconButton();
			this.label3 = new System.Windows.Forms.Label();
			this.Password = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.UserName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.StudentName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(250, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(305, 15);
			this.label5.TabIndex = 64;
			this.label5.Text = "Please fill out the following information to add a student";
			// 
			// AddStudent
			// 
			this.AddStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.AddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.AddStudent.FlatAppearance.BorderSize = 0;
			this.AddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddStudent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddStudent.ForeColor = System.Drawing.Color.White;
			this.AddStudent.IconChar = FontAwesome.Sharp.IconChar.None;
			this.AddStudent.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.AddStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.AddStudent.IconSize = 30;
			this.AddStudent.Location = new System.Drawing.Point(257, 333);
			this.AddStudent.Name = "AddStudent";
			this.AddStudent.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.AddStudent.Size = new System.Drawing.Size(286, 31);
			this.AddStudent.TabIndex = 72;
			this.AddStudent.Text = "Add Student";
			this.AddStudent.UseVisualStyleBackColor = false;
			this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(260, 271);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 15);
			this.label3.TabIndex = 71;
			this.label3.Text = "Password";
			// 
			// Password
			// 
			this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Password.Location = new System.Drawing.Point(257, 291);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(286, 23);
			this.Password.TabIndex = 70;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(260, 212);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 15);
			this.label2.TabIndex = 69;
			this.label2.Text = "Username";
			// 
			// UserName
			// 
			this.UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.UserName.Location = new System.Drawing.Point(257, 232);
			this.UserName.Name = "UserName";
			this.UserName.Size = new System.Drawing.Size(286, 23);
			this.UserName.TabIndex = 68;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(260, 155);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 15);
			this.label1.TabIndex = 67;
			this.label1.Text = "Name";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(345, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 20);
			this.label4.TabIndex = 66;
			this.label4.Text = "Add Student";
			// 
			// StudentName
			// 
			this.StudentName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.StudentName.Location = new System.Drawing.Point(257, 175);
			this.StudentName.Name = "StudentName";
			this.StudentName.Size = new System.Drawing.Size(286, 23);
			this.StudentName.TabIndex = 65;
			// 
			// UC_AddStudent
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.AddStudent);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.UserName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.StudentName);
			this.Controls.Add(this.label5);
			this.Name = "UC_AddStudent";
			this.Size = new System.Drawing.Size(801, 473);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label5;
		private FontAwesome.Sharp.IconButton AddStudent;
		public System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Password;
		public System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox UserName;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox StudentName;
	}
}
