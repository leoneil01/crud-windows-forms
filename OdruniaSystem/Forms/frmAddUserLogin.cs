using OdruniaSystem.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdruniaSystem.Forms
{
	public partial class frmAddUserLogin : Form
	{
		public frmAddUserLogin()
		{
			InitializeComponent();
		}

		Functions.Check check = new Functions.Check();
		Functions.Gender gender = new Functions.Gender();
		Functions.User user = new Functions.User();

		private void frmAddUserLogin_LoadGender(object sender, EventArgs e)
		{
			gender.LoadGendersInCmb(cmbGender);
		}

		string imgLocation = "";

		private void btnLoginAdd_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtFirstName.Text))
			{
				MessageBox.Show("First Name is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtFirstName.Focus();
			}
			else if (String.IsNullOrWhiteSpace(txtLastName.Text))
			{
				MessageBox.Show("Last Name is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtLastName.Focus();
			}

			else if (String.IsNullOrWhiteSpace(cmbGender.Text))
			{
				MessageBox.Show("Gender is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cmbGender.Focus();
			}
			else if (String.IsNullOrWhiteSpace(txtContactNumber.Text) && String.IsNullOrWhiteSpace(txtEmail.Text))
			{
				MessageBox.Show("Please provide contact information either contact number or email!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtContactNumber.Focus();
			}
			else if (String.IsNullOrWhiteSpace(txtUsername.Text))
			{
				MessageBox.Show("Username is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtUsername.Focus();
			}
			else if (String.IsNullOrWhiteSpace(txtPassword.Text))
			{
				MessageBox.Show("Password is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPassword.Focus();
			}
			else if (String.IsNullOrWhiteSpace(txtConfirmPass.Text))
			{
				MessageBox.Show("Confirm Password is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtConfirmPass.Focus();
			}
			else if (check.IsUsernameExists(txtUsername.Text))
			{
				MessageBox.Show("Username is already exists!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

				txtUsername.SelectAll();
				txtUsername.Focus();
			}
			else if (txtPassword.Text != txtConfirmPass.Text)
			{
				MessageBox.Show("Password does not match!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

				txtPassword.SelectAll();
				txtConfirmPass.SelectAll();
				txtPassword.Focus();
			}
			else
			{
				byte[] profilePicture = null;
				if (!String.IsNullOrWhiteSpace(imgLocation))
				{
					FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
					BinaryReader br = new BinaryReader(fs);
					profilePicture = br.ReadBytes((int)fs.Length);
				}

				int age = DateTime.Today.Year - dateBirthday.Value.Year;
				if (dateBirthday.Value.Date > DateTime.Today.AddYears(-age))
				{
					age--;
				}

				if (user.AddUser(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtFirstName.Text), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtMiddleName.Text), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtLastName.Text), cmbGender.Text, age, dateBirthday.Value.Date, txtContactNumber.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text, profilePicture))
				{
					MessageBox.Show("User successfully added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

					frmLogin frmLogin = new frmLogin();
					frmLogin.Show();
					this.Close();
				}
				else
				{
					MessageBox.Show("Failed to add user!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			frmLogin frmLogin = new frmLogin();
			frmLogin.Show();
			this.Close();
		}
	}
}
