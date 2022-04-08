namespace SchoolManagementSystem.UserControls.AdminControls
{
	partial class UC_ManageFees
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
			this.label5 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Amount = new System.Windows.Forms.NumericUpDown();
			this.Assign = new FontAwesome.Sharp.IconButton();
			((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
			this.SuspendLayout();
			// 
			// Students
			// 
			this.Students.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.Students.FormattingEnabled = true;
			this.Students.Location = new System.Drawing.Point(228, 117);
			this.Students.Name = "Students";
			this.Students.Size = new System.Drawing.Size(319, 23);
			this.Students.TabIndex = 53;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(225, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 15);
			this.label2.TabIndex = 52;
			this.label2.Text = "Select student:";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(231, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(316, 15);
			this.label5.TabIndex = 48;
			this.label5.Text = "Please fill the following information to assign student dues";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(310, 30);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(159, 20);
			this.label7.TabIndex = 47;
			this.label7.Text = "Manage Student Fees";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(225, 143);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 15);
			this.label1.TabIndex = 54;
			this.label1.Text = "Amount:";
			// 
			// Amount
			// 
			this.Amount.DecimalPlaces = 1;
			this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.Amount.Location = new System.Drawing.Point(228, 161);
			this.Amount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.Amount.Name = "Amount";
			this.Amount.Size = new System.Drawing.Size(319, 21);
			this.Amount.TabIndex = 55;
			this.Amount.ThousandsSeparator = true;
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
			this.Assign.Location = new System.Drawing.Point(228, 198);
			this.Assign.Name = "Assign";
			this.Assign.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.Assign.Size = new System.Drawing.Size(319, 31);
			this.Assign.TabIndex = 51;
			this.Assign.Text = "Assign Dues";
			this.Assign.UseVisualStyleBackColor = false;
			this.Assign.Click += new System.EventHandler(this.Assign_Click);
			// 
			// UC_ManageFees
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.Amount);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Students);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Assign);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Name = "UC_ManageFees";
			this.Size = new System.Drawing.Size(801, 473);
			this.Load += new System.EventHandler(this.UC_ManageFees_Load);
			((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox Students;
		public System.Windows.Forms.Label label2;
		private FontAwesome.Sharp.IconButton Assign;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown Amount;
	}
}
