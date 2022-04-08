﻿
namespace SchoolManagementSystem.UserControls.Inventory
{
	partial class UC_ViewGrades
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
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Back = new System.Windows.Forms.PictureBox();
			this.Navbar = new System.Windows.Forms.Panel();
			this.NavTitle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
			this.Navbar.SuspendLayout();
			this.SuspendLayout();
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
            this.classDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.studentDataGridViewTextBoxColumn});
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
			this.dg.Location = new System.Drawing.Point(59, 128);
			this.dg.MultiSelect = false;
			this.dg.Name = "dg";
			this.dg.ReadOnly = true;
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			this.dg.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dg.Size = new System.Drawing.Size(675, 355);
			this.dg.TabIndex = 30;
			this.dg.TabStop = false;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// classDataGridViewTextBoxColumn
			// 
			this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
			this.classDataGridViewTextBoxColumn.HeaderText = "Class";
			this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
			this.classDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// resultDataGridViewTextBoxColumn
			// 
			this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
			this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
			this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
			this.resultDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// studentDataGridViewTextBoxColumn
			// 
			this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
			this.studentDataGridViewTextBoxColumn.HeaderText = "Student";
			this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
			this.studentDataGridViewTextBoxColumn.ReadOnly = true;
			this.studentDataGridViewTextBoxColumn.Visible = false;
			// 
			// gradeBindingSource
			// 
			this.gradeBindingSource.DataSource = typeof(SchoolManagementSystem.Grade);
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
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(304, 77);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(162, 15);
			this.label5.TabIndex = 35;
			this.label5.Text = "Your grades in all courses are:";
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
			// UC_ViewGrades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.Navbar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dg);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "UC_ViewGrades";
			this.Size = new System.Drawing.Size(801, 498);
			this.Load += new System.EventHandler(this.UC_InventoryIn_Load);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
			this.Navbar.ResumeLayout(false);
			this.Navbar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Panel Navbar;
		private System.Windows.Forms.PictureBox Back;
		public System.Windows.Forms.Label NavTitle;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource gradeBindingSource;
	}
}
