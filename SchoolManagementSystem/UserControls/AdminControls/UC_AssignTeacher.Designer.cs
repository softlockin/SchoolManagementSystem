
namespace SchoolManagementSystem.UserControls.Shipment
{
	partial class UC_AssignTeacher
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
			this.Canva = new System.Windows.Forms.Panel();
			this.Assign = new FontAwesome.Sharp.IconButton();
			this.Teachers = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Classes = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.NavTitle = new System.Windows.Forms.Label();
			this.DeleteButton = new FontAwesome.Sharp.IconButton();
			this.Canva.SuspendLayout();
			this.SuspendLayout();
			// 
			// Canva
			// 
			this.Canva.Controls.Add(this.DeleteButton);
			this.Canva.Controls.Add(this.Assign);
			this.Canva.Controls.Add(this.Teachers);
			this.Canva.Controls.Add(this.label2);
			this.Canva.Controls.Add(this.Classes);
			this.Canva.Controls.Add(this.label1);
			this.Canva.Controls.Add(this.NavTitle);
			this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canva.Location = new System.Drawing.Point(0, 0);
			this.Canva.Name = "Canva";
			this.Canva.Size = new System.Drawing.Size(801, 498);
			this.Canva.TabIndex = 5;
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
			this.Assign.Location = new System.Drawing.Point(226, 230);
			this.Assign.Name = "Assign";
			this.Assign.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.Assign.Size = new System.Drawing.Size(319, 31);
			this.Assign.TabIndex = 21;
			this.Assign.Text = "Assign teacher to Class";
			this.Assign.UseVisualStyleBackColor = false;
			this.Assign.Click += new System.EventHandler(this.Assign_Click);
			// 
			// Teachers
			// 
			this.Teachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.Teachers.FormattingEnabled = true;
			this.Teachers.Location = new System.Drawing.Point(226, 186);
			this.Teachers.Name = "Teachers";
			this.Teachers.Size = new System.Drawing.Size(319, 23);
			this.Teachers.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(223, 168);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 15);
			this.label2.TabIndex = 12;
			this.label2.Text = "Select Teacher:";
			// 
			// Classes
			// 
			this.Classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.Classes.FormattingEnabled = true;
			this.Classes.Location = new System.Drawing.Point(226, 131);
			this.Classes.Name = "Classes";
			this.Classes.Size = new System.Drawing.Size(319, 23);
			this.Classes.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(223, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 15);
			this.label1.TabIndex = 10;
			this.label1.Text = "Select Class:";
			// 
			// NavTitle
			// 
			this.NavTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.NavTitle.AutoSize = true;
			this.NavTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.NavTitle.ForeColor = System.Drawing.Color.Black;
			this.NavTitle.Location = new System.Drawing.Point(288, 58);
			this.NavTitle.Name = "NavTitle";
			this.NavTitle.Size = new System.Drawing.Size(172, 20);
			this.NavTitle.TabIndex = 9;
			this.NavTitle.Text = "Assign Teacher to Class";
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
			this.DeleteButton.Location = new System.Drawing.Point(226, 267);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.DeleteButton.Size = new System.Drawing.Size(319, 31);
			this.DeleteButton.TabIndex = 22;
			this.DeleteButton.Text = "Delete selected Teacher";
			this.DeleteButton.UseVisualStyleBackColor = false;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// UC_AssignTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Canva);
			this.Name = "UC_AssignTeacher";
			this.Size = new System.Drawing.Size(801, 498);
			this.Load += new System.EventHandler(this.UC_AssignTeacher_Load);
			this.Canva.ResumeLayout(false);
			this.Canva.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Canva;
		public System.Windows.Forms.Label NavTitle;
		public System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox Classes;
		private System.Windows.Forms.ComboBox Teachers;
		public System.Windows.Forms.Label label2;
		private FontAwesome.Sharp.IconButton Assign;
		private FontAwesome.Sharp.IconButton DeleteButton;
	}
}
