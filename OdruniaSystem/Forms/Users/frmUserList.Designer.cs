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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAddUser = new System.Windows.Forms.Button();
			this.btnViewUser = new System.Windows.Forms.Button();
			this.btnUpdateUser = new System.Windows.Forms.Button();
			this.btnDeleteUser = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.gridUsers = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(482, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "USER LISTS";
			// 
			// btnAddUser
			// 
			this.btnAddUser.AutoSize = true;
			this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddUser.Location = new System.Drawing.Point(12, 72);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(107, 28);
			this.btnAddUser.TabIndex = 1;
			this.btnAddUser.TabStop = false;
			this.btnAddUser.Text = "Add User";
			this.btnAddUser.UseVisualStyleBackColor = true;
			this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
			// 
			// btnViewUser
			// 
			this.btnViewUser.AutoSize = true;
			this.btnViewUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnViewUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnViewUser.Location = new System.Drawing.Point(12, 106);
			this.btnViewUser.Name = "btnViewUser";
			this.btnViewUser.Size = new System.Drawing.Size(107, 28);
			this.btnViewUser.TabIndex = 2;
			this.btnViewUser.TabStop = false;
			this.btnViewUser.Text = "View User";
			this.btnViewUser.UseVisualStyleBackColor = true;
			this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
			// 
			// btnUpdateUser
			// 
			this.btnUpdateUser.AutoSize = true;
			this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpdateUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateUser.Location = new System.Drawing.Point(12, 140);
			this.btnUpdateUser.Name = "btnUpdateUser";
			this.btnUpdateUser.Size = new System.Drawing.Size(107, 28);
			this.btnUpdateUser.TabIndex = 3;
			this.btnUpdateUser.TabStop = false;
			this.btnUpdateUser.Text = "Update User";
			this.btnUpdateUser.UseVisualStyleBackColor = true;
			this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
			// 
			// btnDeleteUser
			// 
			this.btnDeleteUser.AutoSize = true;
			this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteUser.Location = new System.Drawing.Point(12, 318);
			this.btnDeleteUser.Name = "btnDeleteUser";
			this.btnDeleteUser.Size = new System.Drawing.Size(107, 28);
			this.btnDeleteUser.TabIndex = 4;
			this.btnDeleteUser.TabStop = false;
			this.btnDeleteUser.Text = "Delete User";
			this.btnDeleteUser.UseVisualStyleBackColor = true;
			this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel1.Controls.Add(this.btnAddUser);
			this.panel1.Controls.Add(this.btnDeleteUser);
			this.panel1.Controls.Add(this.btnViewUser);
			this.panel1.Controls.Add(this.btnUpdateUser);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(133, 358);
			this.panel1.TabIndex = 5;
			// 
			// gridUsers
			// 
			this.gridUsers.AllowUserToAddRows = false;
			this.gridUsers.AllowUserToDeleteRows = false;
			this.gridUsers.AllowUserToResizeColumns = false;
			this.gridUsers.AllowUserToResizeRows = false;
			this.gridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridUsers.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridUsers.DefaultCellStyle = dataGridViewCellStyle2;
			this.gridUsers.Location = new System.Drawing.Point(133, 59);
			this.gridUsers.Name = "gridUsers";
			this.gridUsers.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridUsers.RowHeadersVisible = false;
			this.gridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridUsers.Size = new System.Drawing.Size(846, 299);
			this.gridUsers.TabIndex = 6;
			this.gridUsers.TabStop = false;
			// 
			// frmUserList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(979, 358);
			this.Controls.Add(this.gridUsers);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "frmUserList";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User List";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmUserList_Load);
			this.VisibleChanged += new System.EventHandler(this.frmUserList_VisibleChanged);
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
	}
}