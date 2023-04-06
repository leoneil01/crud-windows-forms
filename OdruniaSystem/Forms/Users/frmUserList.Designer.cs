namespace OdruniaSystem.Forms.Users
{
	partial class frmUserList
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAddUser = new System.Windows.Forms.Button();
			this.btnViewUser = new System.Windows.Forms.Button();
			this.btnUpdateUser = new System.Windows.Forms.Button();
			this.btnDeleteUser = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.gridUsers = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(400, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "USER LISTS";
			// 
			// btnAddUser
			// 
			this.btnAddUser.AutoSize = true;
			this.btnAddUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddUser.Location = new System.Drawing.Point(12, 72);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(107, 28);
			this.btnAddUser.TabIndex = 1;
			this.btnAddUser.Text = "Add User";
			this.btnAddUser.UseVisualStyleBackColor = true;
			this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
			// 
			// btnViewUser
			// 
			this.btnViewUser.AutoSize = true;
			this.btnViewUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnViewUser.Location = new System.Drawing.Point(12, 106);
			this.btnViewUser.Name = "btnViewUser";
			this.btnViewUser.Size = new System.Drawing.Size(107, 28);
			this.btnViewUser.TabIndex = 2;
			this.btnViewUser.Text = "View User";
			this.btnViewUser.UseVisualStyleBackColor = true;
			// 
			// btnUpdateUser
			// 
			this.btnUpdateUser.AutoSize = true;
			this.btnUpdateUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateUser.Location = new System.Drawing.Point(12, 140);
			this.btnUpdateUser.Name = "btnUpdateUser";
			this.btnUpdateUser.Size = new System.Drawing.Size(107, 28);
			this.btnUpdateUser.TabIndex = 3;
			this.btnUpdateUser.Text = "Update User";
			this.btnUpdateUser.UseVisualStyleBackColor = true;
			// 
			// btnDeleteUser
			// 
			this.btnDeleteUser.AutoSize = true;
			this.btnDeleteUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteUser.Location = new System.Drawing.Point(12, 410);
			this.btnDeleteUser.Name = "btnDeleteUser";
			this.btnDeleteUser.Size = new System.Drawing.Size(107, 28);
			this.btnDeleteUser.TabIndex = 4;
			this.btnDeleteUser.Text = "Delete User";
			this.btnDeleteUser.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Info;
			this.panel1.Controls.Add(this.btnAddUser);
			this.panel1.Controls.Add(this.btnDeleteUser);
			this.panel1.Controls.Add(this.btnViewUser);
			this.panel1.Controls.Add(this.btnUpdateUser);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(133, 450);
			this.panel1.TabIndex = 5;
			// 
			// gridUsers
			// 
			this.gridUsers.AllowUserToAddRows = false;
			this.gridUsers.AllowUserToDeleteRows = false;
			this.gridUsers.AllowUserToResizeColumns = false;
			this.gridUsers.AllowUserToResizeRows = false;
			this.gridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridUsers.DefaultCellStyle = dataGridViewCellStyle6;
			this.gridUsers.Location = new System.Drawing.Point(133, 59);
			this.gridUsers.Name = "gridUsers";
			this.gridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridUsers.Size = new System.Drawing.Size(667, 391);
			this.gridUsers.TabIndex = 6;
			this.gridUsers.TabStop = false;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "First Name";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Middle Name";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Last Name";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Gender";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Age";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Birthday";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Contact Number";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Email";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// Column9
			// 
			this.Column9.HeaderText = "Username";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			// 
			// frmUserList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gridUsers);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "frmUserList";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OdruniaSystem";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddUser;
		private System.Windows.Forms.Button btnViewUser;
		private System.Windows.Forms.Button btnUpdateUser;
		private System.Windows.Forms.Button btnDeleteUser;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.DataGridView gridUsers;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
	}
}