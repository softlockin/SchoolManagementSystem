
namespace SchoolManagementSystem.UserControls.Inventory
{
	partial class UC_Grades
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.SoftwareName = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Grades = new System.Windows.Forms.ComboBox();
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.gradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.Save = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Back = new System.Windows.Forms.PictureBox();
			this.Students = new System.Windows.Forms.ComboBox();
			this.Classes = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Navbar = new System.Windows.Forms.Panel();
			this.NavTitle = new System.Windows.Forms.Label();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
			this.Navbar.SuspendLayout();
			this.SuspendLayout();
			// 
			// SoftwareName
			// 
			this.SoftwareName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.SoftwareName.AutoSize = true;
			this.SoftwareName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.SoftwareName.ForeColor = System.Drawing.Color.Black;
			this.SoftwareName.Location = new System.Drawing.Point(348, 230);
			this.SoftwareName.Name = "SoftwareName";
			this.SoftwareName.Size = new System.Drawing.Size(97, 20);
			this.SoftwareName.TabIndex = 2;
			this.SoftwareName.Text = "Class Grades";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(83, 154);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 15);
			this.label4.TabIndex = 24;
			this.label4.Text = "Student";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(402, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 15);
			this.label2.TabIndex = 23;
			this.label2.Text = "Grade";
			// 
			// Grades
			// 
			this.Grades.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Grades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Grades.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Grades.FormattingEnabled = true;
			this.Grades.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
			this.Grades.Location = new System.Drawing.Point(461, 149);
			this.Grades.Name = "Grades";
			this.Grades.Size = new System.Drawing.Size(247, 25);
			this.Grades.TabIndex = 1;
			// 
			// dg
			// 
			this.dg.AllowUserToAddRows = false;
			this.dg.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dg.AutoGenerateColumns = false;
			this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dg.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.studentDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn});
			this.dg.DataSource = this.gradeBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dg.DefaultCellStyle = dataGridViewCellStyle3;
			this.dg.DoubleBuffered = true;
			this.dg.EnableHeadersVisualStyles = false;
			this.dg.HeaderBgColor = System.Drawing.Color.Maroon;
			this.dg.HeaderForeColor = System.Drawing.Color.White;
			this.dg.Location = new System.Drawing.Point(59, 259);
			this.dg.MultiSelect = false;
			this.dg.Name = "dg";
			this.dg.ReadOnly = true;
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			this.dg.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dg.Size = new System.Drawing.Size(675, 224);
			this.dg.TabIndex = 30;
			this.dg.TabStop = false;
			// 
			// gradeBindingSource
			// 
			this.gradeBindingSource.DataSource = typeof(SchoolManagementSystem.Grade);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.BackColor = System.Drawing.Color.Maroon;
			this.panel1.Location = new System.Drawing.Point(140, 223);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(517, 1);
			this.panel1.TabIndex = 31;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(363, 44);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 20);
			this.label7.TabIndex = 32;
			this.label7.Text = "Grades";
			// 
			// Save
			// 
			this.Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Save.Location = new System.Drawing.Point(336, 183);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(141, 29);
			this.Save.TabIndex = 5;
			this.Save.Text = "Save";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(56, 76);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(396, 15);
			this.label5.TabIndex = 35;
			this.label5.Text = "Please fill out the following information to register new inventory in entry.";
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 7;
			this.bunifuElipse1.TargetControl = this.dg;
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
			// Students
			// 
			this.Students.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Students.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Students.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Students.FormattingEnabled = true;
			this.Students.Location = new System.Drawing.Point(137, 149);
			this.Students.Name = "Students";
			this.Students.Size = new System.Drawing.Size(238, 25);
			this.Students.TabIndex = 36;
			// 
			// Classes
			// 
			this.Classes.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Classes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Classes.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Classes.FormattingEnabled = true;
			this.Classes.Location = new System.Drawing.Point(137, 116);
			this.Classes.Name = "Classes";
			this.Classes.Size = new System.Drawing.Size(571, 25);
			this.Classes.TabIndex = 38;
			this.Classes.SelectedIndexChanged += new System.EventHandler(this.Classes_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(83, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 15);
			this.label1.TabIndex = 37;
			this.label1.Text = "Class";
			// 
			// Navbar
			// 
			this.Navbar.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.Navbar.Controls.Add(this.Back);
			this.Navbar.Controls.Add(this.NavTitle);
			this.Navbar.Dock = System.Windows.Forms.DockStyle.Top;
			this.Navbar.Location = new System.Drawing.Point(0, 0);
			this.Navbar.Name = "Navbar";
			this.Navbar.Size = new System.Drawing.Size(801, 30);
			this.Navbar.TabIndex = 39;
			// 
			// NavTitle
			// 
			this.NavTitle.AutoSize = true;
			this.NavTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.NavTitle.ForeColor = System.Drawing.Color.Black;
			this.NavTitle.Location = new System.Drawing.Point(35, 6);
			this.NavTitle.Name = "NavTitle";
			this.NavTitle.Size = new System.Drawing.Size(187, 19);
			this.NavTitle.TabIndex = 7;
			this.NavTitle.Text = "School Management System ";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Student";
			this.dataGridViewTextBoxColumn1.HeaderText = "Student";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 338;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// studentDataGridViewTextBoxColumn
			// 
			this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
			this.studentDataGridViewTextBoxColumn.HeaderText = "Student";
			this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
			this.studentDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// resultDataGridViewTextBoxColumn
			// 
			this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
			this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
			this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
			this.resultDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// classDataGridViewTextBoxColumn
			// 
			this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
			this.classDataGridViewTextBoxColumn.HeaderText = "Class";
			this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
			this.classDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// UC_Grades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.Navbar);
			this.Controls.Add(this.Classes);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Students);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Save);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Grades);
			this.Controls.Add(this.SoftwareName);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "UC_Grades";
			this.Size = new System.Drawing.Size(801, 498);
			this.Load += new System.EventHandler(this.UC_Grades_Load);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
			this.Navbar.ResumeLayout(false);
			this.Navbar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label SoftwareName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox Grades;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.Label label5;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ComboBox Students;
		private System.Windows.Forms.ComboBox Classes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel Navbar;
		private System.Windows.Forms.PictureBox Back;
		public System.Windows.Forms.Label NavTitle;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.BindingSource gradeBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
	}
}
