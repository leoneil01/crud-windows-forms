using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdruniaSystem
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		Components.Value val = new Components.Value();
		Functions.Login login = new Functions.Login();

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			Forms.frmDashboard frmDashboard = new Forms.frmDashboard();
			frmDashboard.pnlDashboard.Controls.Clear();
			Forms.Users.frmUserList frmUserList = new Forms.Users.frmUserList();
			frmUserList.TopLevel = false;
			frmDashboard.pnlDashboard.Controls.Add(frmUserList);
			frmUserList.Dock = DockStyle.Fill;

			Forms.frmAddUserLogin frmAddUser = new Forms.frmAddUserLogin();
			frmAddUser.Show();
			this.Hide();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if(String.IsNullOrWhiteSpace(txtUsername.Text) && String.IsNullOrWhiteSpace(txtPassword.Text))
			{
				MessageBox.Show("Username and Password are required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtUsername.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtUsername.Text))
			{
				MessageBox.Show("Username is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtUsername.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtPassword.Text))
			{
				MessageBox.Show("Password is reuiqred!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPassword.Focus();
			}
			else if(login.AuthenticateUser(txtUsername.Text, txtPassword.Text))
			{
				Forms.frmDashboard frmDashboard = new Forms.frmDashboard();
				frmDashboard.Show();
				this.Hide();

				MessageBox.Show($"Welcome {val.MyFullName}!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Your credentials does not match in our record!", "", MessageBoxButtons.OK, MessageBoxIcon.Error );
				txtUsername.SelectAll();
				txtPassword.SelectAll();
				txtUsername.Focus();
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
