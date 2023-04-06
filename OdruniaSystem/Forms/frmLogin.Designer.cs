namespace OdruniaSystem
{
	partial class frmLogin
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAddUser = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(60, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username";
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(65, 81);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(229, 26);
			this.txtUsername.TabIndex = 0;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(65, 149);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(229, 26);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(60, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			// 
			// btnAddUser
			// 
			this.btnAddUser.AutoSize = true;
			this.btnAddUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddUser.Location = new System.Drawing.Point(130, 197);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(105, 28);
			this.btnAddUser.TabIndex = 4;
			this.btnAddUser.Text = "Add User";
			this.btnAddUser.UseVisualStyleBackColor = true;
			this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.AutoSize = true;
			this.btnLogin.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(184, 231);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(94, 28);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnExit
			// 
			this.btnExit.AutoSize = true;
			this.btnExit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(84, 231);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(94, 28);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(369, 349);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnAddUser);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmLogin";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OdruniaSystem";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAddUser;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnExit;
	}
}

