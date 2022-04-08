
namespace SchoolManagementSystem.UserControls.Inventory
{
	partial class UC_Attendance
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
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Classes = new System.Windows.Forms.ComboBox();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Back = new System.Windows.Forms.PictureBox();
			this.Save = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Date = new System.Windows.Forms.DateTimePicker();
			this.Navbar = new System.Windows.Forms.Panel();
			this.NavTitle = new System.Windows.Forms.Label();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isPresentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Save)).BeginInit();
			this.Navbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(354, 34);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 20);
			this.label7.TabIndex = 51;
			this.label7.Text = "Attendance";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(210, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(357, 15);
			this.label5.TabIndex = 53;
			this.label5.Text = "Please select a Class from the following dropdown to get students:";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(205, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 15);
			this.label2.TabIndex = 55;
			this.label2.Text = "Class";
			// 
			// Classes
			// 
			this.Classes.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Classes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Classes.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Classes.FormattingEnabled = true;
			this.Classes.Location = new System.Drawing.Point(245, 91);
			this.Classes.Name = "Classes";
			this.Classes.Size = new System.Drawing.Size(153, 25);
			this.Classes.Sorted = true;
			this.Classes.TabIndex = 54;
			this.Classes.SelectedIndexChanged += new System.EventHandler(this.Classes_SelectedIndexChanged);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 7;
			this.bunifuElipse1.TargetControl = this.dg;
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
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.studentDataGridViewTextBoxColumn,
            this.isPresentDataGridViewCheckBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.teacherDataGridViewTextBoxColumn});
			this.dg.DataSource = this.attendanceBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dg.DefaultCellStyle = dataGridViewCellStyle3;
			this.dg.DoubleBuffered = true;
			this.dg.EnableHeadersVisualStyles = false;
			this.dg.HeaderBgColor = System.Drawing.Color.Maroon;
			this.dg.HeaderForeColor = System.Drawing.Color.White;
			this.dg.Location = new System.Drawing.Point(61, 133);
			this.dg.MultiSelect = false;
			this.dg.Name = "dg";
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			this.dg.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dg.Size = new System.Drawing.Size(675, 330);
			this.dg.TabIndex = 56;
			this.dg.TabStop = false;
			this.dg.CurrentCellDirtyStateChanged += new System.EventHandler(this.dg_CurrentCellDirtyStateChanged);
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
			// Save
			// 
			this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Save.BackColor = System.Drawing.Color.White;
			this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Save.Image = global::SchoolManagementSystem.Properties.Resources.icons8_report_file_24px_2;
			this.Save.Location = new System.Drawing.Point(712, 103);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(24, 24);
			this.Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Save.TabIndex = 63;
			this.Save.TabStop = false;
			this.toolTip1.SetToolTip(this.Save, "Save Attendance");
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(407, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 15);
			this.label1.TabIndex = 60;
			this.label1.Text = "Date";
			// 
			// Date
			// 
			this.Date.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.Date.Location = new System.Drawing.Point(444, 91);
			this.Date.Name = "Date";
			this.Date.Size = new System.Drawing.Size(158, 23);
			this.Date.TabIndex = 61;
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
			this.Navbar.TabIndex = 62;
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
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.Visible = false;
			// 
			// studentDataGridViewTextBoxColumn
			// 
			this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
			this.studentDataGridViewTextBoxColumn.HeaderText = "Student";
			this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
			this.studentDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// isPresentDataGridViewCheckBoxColumn
			// 
			this.isPresentDataGridViewCheckBoxColumn.DataPropertyName = "IsPresent";
			this.isPresentDataGridViewCheckBoxColumn.HeaderText = "Is Present";
			this.isPresentDataGridViewCheckBoxColumn.Name = "isPresentDataGridViewCheckBoxColumn";
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// classDataGridViewTextBoxColumn
			// 
			this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
			this.classDataGridViewTextBoxColumn.HeaderText = "Class";
			this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
			this.classDataGridViewTextBoxColumn.Visible = false;
			// 
			// teacherDataGridViewTextBoxColumn
			// 
			this.teacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher";
			this.teacherDataGridViewTextBoxColumn.HeaderText = "Teacher";
			this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
			this.teacherDataGridViewTextBoxColumn.Visible = false;
			// 
			// attendanceBindingSource
			// 
			this.attendanceBindingSource.DataSource = typeof(SchoolManagementSystem.Attendance);
			// 
			// UC_Attendance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.Save);
			this.Controls.Add(this.Navbar);
			this.Controls.Add(this.Date);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Classes);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Name = "UC_Attendance";
			this.Size = new System.Drawing.Size(801, 473);
			this.Load += new System.EventHandler(this.UC_Attendance_Load);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Save)).EndInit();
			this.Navbar.ResumeLayout(false);
			this.Navbar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox Classes;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker Date;
		private System.Windows.Forms.Panel Navbar;
		private System.Windows.Forms.PictureBox Back;
		public System.Windows.Forms.Label NavTitle;
		private System.Windows.Forms.PictureBox Save;
		private System.Windows.Forms.BindingSource attendanceBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isPresentDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
	}
}
