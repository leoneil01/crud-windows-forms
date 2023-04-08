using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OdruniaSystem.Forms.Users
{
	public partial class frmAddUser : Form
	{
		public frmAddUser()
		{
			InitializeComponent();
		}

        Functions.Check check = new Functions.Check();
		Functions.Gender gender = new Functions.Gender();
		Functions.User user = new Functions.User();

		private void frmAddUser_LoadGender(object sender, EventArgs e)
		{
			gender.LoadGendersInCmb(cmbGender);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if(String.IsNullOrWhiteSpace(txtFirstName.Text))
			{
				MessageBox.Show("First Name is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtFirstName.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtLastName.Text))
			{
				MessageBox.Show("Last Name is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtLastName.Focus();
			}

			else if(String.IsNullOrWhiteSpace(cmbGender.Text))
			{
				MessageBox.Show("Gender is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cmbGender.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtContactNumber.Text) && String.IsNullOrWhiteSpace(txtEmail.Text))
			{
				MessageBox.Show("Please provide contact information either contact number or email!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtContactNumber.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtUsername.Text))
			{
				MessageBox.Show("Username is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtUsername.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtPassword.Text))
			{
				MessageBox.Show("Password is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPassword.Focus();
			}
			else if(String.IsNullOrWhiteSpace(txtConfirmPass.Text))
			{
				MessageBox.Show("Confirm Password is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtConfirmPass.Focus();
			}
			else if(check.IsUsernameExists(txtUsername.Text))
			{
				MessageBox.Show("Username is already exists!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

				txtUsername.SelectAll();
				txtUsername.Focus();
			}
			else if(txtPassword.Text != txtConfirmPass.Text)
			{
				MessageBox.Show("Password does not match!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

				txtPassword.SelectAll();
				txtConfirmPass.SelectAll();
				txtPassword.Focus();
			}
			else
			{
				int age = DateTime.Today.Year - dateBirthday.Value.Year;
				if(dateBirthday.Value.Date > DateTime.Today.AddYears(-age))
				{
					age--;
				}

				if (user.AddUser(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtFirstName.Text), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtMiddleName.Text), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtLastName.Text), cmbGender.Text, age, dateBirthday.Value.Date, txtContactNumber.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text))
				{
					MessageBox.Show("User successfully added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

					txtFirstName.ResetText();
					txtMiddleName.ResetText();
					txtLastName.ResetText();
					cmbGender.Text = null;
					dateBirthday.Value = DateTime.Today;
					txtContactNumber.ResetText();
					txtEmail.ResetText();
					txtUsername.ResetText();
					txtPassword.ResetText();
					txtConfirmPass .ResetText();

					txtFirstName.Focus();
				}
				else
				{
					MessageBox.Show("Failed to add user!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Forms.Users.frmUserList frmUserList = new Forms.Users.frmUserList();
			frmUserList.TopLevel = false;

			Forms.frmDashboard frmDashboard1 = new Forms.frmDashboard();
			frmDashboard1.Show();

			Forms.frmDashboard frmDashboard2 = (Forms.frmDashboard)Application.OpenForms["frmDashboard"];
			Panel pnlDashboard = (Panel)frmDashboard2.Controls["pnlDashboard"];

			pnlDashboard.Controls.Add(frmUserList);
			frmUserList.Dock = DockStyle.Fill;
			frmUserList.Show();
			this.Close();
		}
	}
}
