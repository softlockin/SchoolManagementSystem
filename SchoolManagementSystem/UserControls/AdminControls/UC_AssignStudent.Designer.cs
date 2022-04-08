
namespace SchoolManagementSystem.UserControls.CRM
{
	partial class UC_AssignStudent
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
			this.label1 = new System.Windows.Forms.Label();
			this.Classes = new System.Windows.Forms.ComboBox();
			this.Assign = new FontAwesome.Sharp.IconButton();
			this.label2 = new System.Windows.Forms.Label();
			this.Students = new System.Windows.Forms.ComboBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.DeleteButton = new FontAwesome.Sharp.IconButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(238, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 15);
			this.label1.TabIndex = 42;
			this.label1.Text = "Select Class:";
			// 
			// Classes
			// 
			this.Classes.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.Classes.FormattingEnabled = true;
			this.Classes.Location = new System.Drawing.Point(241, 121);
			this.Classes.Name = "Classes";
			this.Classes.Size = new System.Drawing.Size(319, 23);
			this.Classes.TabIndex = 43;
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
			this.Assign.Location = new System.Drawing.Point(241, 202);
			this.Assign.Name = "Assign";
			this.Assign.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.Assign.Size = new System.Drawing.Size(319, 31);
			this.Assign.TabIndex = 44;
			this.Assign.Text = "Assign to Class";
			this.Assign.UseVisualStyleBackColor = false;
			this.Assign.Click += new System.EventHandler(this.Assign_Click);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(238, 153);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 15);
			this.label2.TabIndex = 45;
			this.label2.Text = "Select student:";
			// 
			// Students
			// 
			this.Students.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.Students.FormattingEnabled = true;
			this.Students.Location = new System.Drawing.Point(241, 171);
			this.Students.Name = "Students";
			this.Students.Size = new System.Drawing.Size(319, 23);
			this.Students.TabIndex = 46;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(311, 23);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(173, 20);
			this.label7.TabIndex = 40;
			this.label7.Text = "Assign Student to Class";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(209, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(351, 15);
			this.label5.TabIndex = 41;
			this.label5.Text = "Please fill out the following information to assign student to class";
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
			this.DeleteButton.Location = new System.Drawing.Point(241, 239);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.DeleteButton.Size = new System.Drawing.Size(319, 31);
			this.DeleteButton.TabIndex = 47;
			this.DeleteButton.Text = "Delete selected Student";
			this.DeleteButton.UseVisualStyleBackColor = false;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// UC_AssignStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.Students);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Assign);
			this.Controls.Add(this.Classes);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.Name = "UC_AssignStudent";
			this.Size = new System.Drawing.Size(801, 473);
			this.Load += new System.EventHandler(this.UC_AssignStudent_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox Classes;
		private FontAwesome.Sharp.IconButton Assign;
		public System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox Students;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private FontAwesome.Sharp.IconButton DeleteButton;
	}
}
