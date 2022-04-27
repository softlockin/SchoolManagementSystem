namespace SchoolManagementSystem.UserControls.AdminControls
{
	partial class UC_AssignParentToStudent
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
			this.Students = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Parents = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.Assign = new FontAwesome.Sharp.IconButton();
			this.RemoveStudentFromClass = new FontAwesome.Sharp.IconButton();
			this.DeleteButton = new FontAwesome.Sharp.IconButton();
			this.SuspendLayout();
			// 
			// Students
			// 
			this.Students.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.Students.FormattingEnabled = true;
			this.Students.Location = new System.Drawing.Point(252, 232);
			this.Students.Name = "Students";
			this.Students.Size = new System.Drawing.Size(319, 23);
			this.Students.TabIndex = 55;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(249, 214);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 15);
			this.label2.TabIndex = 54;
			this.label2.Text = "Select student:";
			// 
			// Parents
			// 
			this.Parents.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Parents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.Parents.FormattingEnabled = true;
			this.Parents.Location = new System.Drawing.Point(252, 182);
			this.Parents.Name = "Parents";
			this.Parents.Size = new System.Drawing.Size(319, 23);
			this.Parents.TabIndex = 52;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(249, 164);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 15);
			this.label1.TabIndex = 51;
			this.label1.Text = "Select Parent:";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(220, 117);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(360, 15);
			this.label5.TabIndex = 50;
			this.label5.Text = "Please fill out the following information to assign parent to student";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(314, 84);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(184, 20);
			this.label7.TabIndex = 49;
			this.label7.Text = "Assign Parent to Student";
			// 
			// Assign
			// 
			this.Assign.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Assign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.Assign.FlatAppearance.BorderSize = 0;
			this.Assign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Assign.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Assign.ForeColor = System.Drawing.Color.White;
			this.Assign.IconChar = FontAwesome.Sharp.IconChar.None;
			this.Assign.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Assign.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.Assign.IconSize = 30;
			this.Assign.Location = new System.Drawing.Point(252, 263);
			this.Assign.Name = "Assign";
			this.Assign.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.Assign.Size = new System.Drawing.Size(319, 31);
			this.Assign.TabIndex = 53;
			this.Assign.Text = "Assign";
			this.Assign.UseVisualStyleBackColor = false;
			this.Assign.Click += new System.EventHandler(this.Assign_Click);
			// 
			// RemoveStudentFromClass
			// 
			this.RemoveStudentFromClass.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RemoveStudentFromClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.RemoveStudentFromClass.FlatAppearance.BorderSize = 0;
			this.RemoveStudentFromClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RemoveStudentFromClass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RemoveStudentFromClass.ForeColor = System.Drawing.Color.White;
			this.RemoveStudentFromClass.IconChar = FontAwesome.Sharp.IconChar.None;
			this.RemoveStudentFromClass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.RemoveStudentFromClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.RemoveStudentFromClass.IconSize = 30;
			this.RemoveStudentFromClass.Location = new System.Drawing.Point(252, 300);
			this.RemoveStudentFromClass.Name = "RemoveStudentFromClass";
			this.RemoveStudentFromClass.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.RemoveStudentFromClass.Size = new System.Drawing.Size(319, 31);
			this.RemoveStudentFromClass.TabIndex = 57;
			this.RemoveStudentFromClass.Text = "Remove parent from student";
			this.RemoveStudentFromClass.UseVisualStyleBackColor = false;
			this.RemoveStudentFromClass.Click += new System.EventHandler(this.RemoveStudentFromClass_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.DeleteButton.FlatAppearance.BorderSize = 0;
			this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteButton.ForeColor = System.Drawing.Color.White;
			this.DeleteButton.IconChar = FontAwesome.Sharp.IconChar.None;
			this.DeleteButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.DeleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.DeleteButton.IconSize = 30;
			this.DeleteButton.Location = new System.Drawing.Point(252, 339);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.DeleteButton.Size = new System.Drawing.Size(319, 31);
			this.DeleteButton.TabIndex = 56;
			this.DeleteButton.Text = "Delete Parent";
			this.DeleteButton.UseVisualStyleBackColor = false;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// UC_AssignParentToStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Students);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Assign);
			this.Controls.Add(this.Parents);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.RemoveStudentFromClass);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Name = "UC_AssignParentToStudent";
			this.Size = new System.Drawing.Size(801, 473);
			this.Load += new System.EventHandler(this.UC_AssignParentToStudent_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox Students;
		public System.Windows.Forms.Label label2;
		private FontAwesome.Sharp.IconButton Assign;
		private System.Windows.Forms.ComboBox Parents;
		public System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolTip toolTip1;
		private FontAwesome.Sharp.IconButton RemoveStudentFromClass;
		private FontAwesome.Sharp.IconButton DeleteButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
	}
}
