﻿namespace OdruniaSystem.Forms
{
	partial class frmDashboard
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnCustomers = new System.Windows.Forms.Button();
			this.btnUsers = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlDashboard = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add(this.btnExit);
			this.panel1.Controls.Add(this.btnCustomers);
			this.panel1.Controls.Add(this.btnUsers);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(979, 95);
			this.panel1.TabIndex = 0;
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnExit.AutoSize = true;
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(12, 32);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(151, 28);
			this.btnExit.TabIndex = 3;
			this.btnExit.TabStop = false;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnCustomers
			// 
			this.btnCustomers.AutoSize = true;
			this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCustomers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCustomers.Location = new System.Drawing.Point(612, 49);
			this.btnCustomers.Name = "btnCustomers";
			this.btnCustomers.Size = new System.Drawing.Size(151, 28);
			this.btnCustomers.TabIndex = 2;
			this.btnCustomers.TabStop = false;
			this.btnCustomers.Text = "Customers";
			this.btnCustomers.UseVisualStyleBackColor = true;
			this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
			// 
			// btnUsers
			// 
			this.btnUsers.AutoSize = true;
			this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUsers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUsers.Location = new System.Drawing.Point(612, 15);
			this.btnUsers.Name = "btnUsers";
			this.btnUsers.Size = new System.Drawing.Size(151, 28);
			this.btnUsers.TabIndex = 1;
			this.btnUsers.TabStop = false;
			this.btnUsers.Text = "Users";
			this.btnUsers.UseVisualStyleBackColor = true;
			this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(799, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "DASHBOARD";
			// 
			// pnlDashboard
			// 
			this.pnlDashboard.BackColor = System.Drawing.SystemColors.Window;
			this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlDashboard.Location = new System.Drawing.Point(0, 92);
			this.pnlDashboard.Margin = new System.Windows.Forms.Padding(2);
			this.pnlDashboard.Name = "pnlDashboard";
			this.pnlDashboard.Size = new System.Drawing.Size(979, 358);
			this.pnlDashboard.TabIndex = 1;
			// 
			// frmDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(979, 450);
			this.Controls.Add(this.pnlDashboard);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmDashboard";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OdruniaSystem";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Panel pnlDashboard;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnCustomers;
		private System.Windows.Forms.Button btnUsers;
	}
}