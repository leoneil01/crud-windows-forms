using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OdruniaSystem.Forms.Users
{
	public partial class frmUpdateUser : Form
	{
		public frmUpdateUser()
		{
			InitializeComponent();
		}

		Components.Value val = new Components.Value();
		Functions.User user = new Functions.User();
		Functions.Gender gender = new Functions.Gender();

		private void frmUpdateUser_Load(object sender, EventArgs e)
		{
			gender.LoadGendersInCmb(cmbGender);

			txtFirstName.Text = val.UserFirstName;
			txtMiddleName.Text = val.UserMiddleName;
			txtLastName.Text = val.UserLastName;
			txtEmail.Text = val.UserEmail;
			cmbGender.Text = val.UserGender;
			dateBirthday.Text = val.UserBirthday.ToString("d");
			txtContactNumber.Text = val.UserContactNumber;
			txtUsername.Text = val.UserUsername;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if(String.IsNullOrWhiteSpace(txtFirstName.Text))
			{
				MessageBox.Show("First Name is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(String.IsNullOrWhiteSpace(txtLastName.Text))
			{
				MessageBox.Show("Last Name is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(String.IsNullOrWhiteSpace(cmbGender.Text))
			{
				MessageBox.Show("Gender is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(String.IsNullOrWhiteSpace(txtContactNumber.Text) && String.IsNullOrWhiteSpace(txtEmail.Text))
			{
				MessageBox.Show("Please provide contact information either contact number or email!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(String.IsNullOrWhiteSpace(txtUsername.Text))
			{
				MessageBox.Show("Username is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				int age = DateTime.Today.Year - dateBirthday.Value.Year;
				if(dateBirthday.Value.Date > DateTime.Today.AddYears(-age))
				{
					age--;
				}

				if (user.UpdateUser(val.UserId, CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtFirstName.Text), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtMiddleName.Text), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtLastName.Text), cmbGender.Text, age, dateBirthday.Value.Date, txtContactNumber.Text, txtEmail.Text, txtUsername.Text))
				{
					MessageBox.Show("User successfully updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Failed to update user!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

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
