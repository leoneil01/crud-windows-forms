﻿namespace OdruniaSystem.Forms.Customers
{
	partial class frmCustomerList
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAddCustomer = new System.Windows.Forms.Button();
			this.btnDeleteCustomer = new System.Windows.Forms.Button();
			this.btnUpdateCustomer = new System.Windows.Forms.Button();
			this.btnViewCustomer = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.gridCustomers = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel1.Controls.Add(this.btnAddCustomer);
			this.panel1.Controls.Add(this.btnDeleteCustomer);
			this.panel1.Controls.Add(this.btnUpdateCustomer);
			this.panel1.Controls.Add(this.btnViewCustomer);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(133, 358);
			this.panel1.TabIndex = 0;
			// 
			// btnAddCustomer
			// 
			this.btnAddCustomer.AutoSize = true;
			this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddCustomer.Location = new System.Drawing.Point(12, 72);
			this.btnAddCustomer.Name = "btnAddCustomer";
			this.btnAddCustomer.Size = new System.Drawing.Size(111, 28);
			this.btnAddCustomer.TabIndex = 5;
			this.btnAddCustomer.TabStop = false;
			this.btnAddCustomer.Text = "Add Customer";
			this.btnAddCustomer.UseVisualStyleBackColor = true;
			this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
			// 
			// btnDeleteCustomer
			// 
			this.btnDeleteCustomer.AutoSize = true;
			this.btnDeleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteCustomer.Location = new System.Drawing.Point(12, 304);
			this.btnDeleteCustomer.Name = "btnDeleteCustomer";
			this.btnDeleteCustomer.Size = new System.Drawing.Size(111, 42);
			this.btnDeleteCustomer.TabIndex = 8;
			this.btnDeleteCustomer.TabStop = false;
			this.btnDeleteCustomer.Text = "Delete\r\nCustomer";
			this.btnDeleteCustomer.UseVisualStyleBackColor = true;
			this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
			// 
			// btnUpdateCustomer
			// 
			this.btnUpdateCustomer.AutoSize = true;
			this.btnUpdateCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpdateCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateCustomer.Location = new System.Drawing.Point(12, 140);
			this.btnUpdateCustomer.Name = "btnUpdateCustomer";
			this.btnUpdateCustomer.Size = new System.Drawing.Size(111, 42);
			this.btnUpdateCustomer.TabIndex = 7;
			this.btnUpdateCustomer.TabStop = false;
			this.btnUpdateCustomer.Text = "Update\r\nCustomer";
			this.btnUpdateCustomer.UseVisualStyleBackColor = true;
			this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
			// 
			// btnViewCustomer
			// 
			this.btnViewCustomer.AutoSize = true;
			this.btnViewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnViewCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnViewCustomer.Location = new System.Drawing.Point(12, 106);
			this.btnViewCustomer.Name = "btnViewCustomer";
			this.btnViewCustomer.Size = new System.Drawing.Size(111, 28);
			this.btnViewCustomer.TabIndex = 6;
			this.btnViewCustomer.TabStop = false;
			this.btnViewCustomer.Text = "View Customer";
			this.btnViewCustomer.UseVisualStyleBackColor = true;
			this.btnViewCustomer.Click += new System.EventHandler(this.btnViewCustomer_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(452, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "CUSTOMER LISTS";
			// 
			// gridCustomers
			// 
			this.gridCustomers.AllowUserToAddRows = false;
			this.gridCustomers.AllowUserToDeleteRows = false;
			this.gridCustomers.AllowUserToResizeColumns = false;
			this.gridCustomers.AllowUserToResizeRows = false;
			this.gridCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.gridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridCustomers.DefaultCellStyle = dataGridViewCellStyle8;
			this.gridCustomers.Location = new System.Drawing.Point(133, 59);
			this.gridCustomers.Name = "gridCustomers";
			this.gridCustomers.ReadOnly = true;
			this.gridCustomers.RowHeadersVisible = false;
			this.gridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridCustomers.Size = new System.Drawing.Size(846, 299);
			this.gridCustomers.TabIndex = 2;
			this.gridCustomers.TabStop = false;
			// 
			// frmCustomerList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(979, 358);
			this.Controls.Add(this.gridCustomers);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmCustomerList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customer List";
			this.Load += new System.EventHandler(this.frmCustomerList_LoadCustomer);
			this.VisibleChanged += new System.EventHandler(this.frmCustomerList_VisibleChanged);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView gridCustomers;
		private System.Windows.Forms.Button btnAddCustomer;
		private System.Windows.Forms.Button btnDeleteCustomer;
		private System.Windows.Forms.Button btnUpdateCustomer;
		private System.Windows.Forms.Button btnViewCustomer;
	}
}