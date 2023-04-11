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

namespace OdruniaSystem.Forms.Customers
{
	public partial class frmAddCustomer : Form
	{
		public frmAddCustomer()
		{
			InitializeComponent();
		}

		Functions.Gender gender = new Functions.Gender();
		Functions.Customer customer = new Functions.Customer();

		private void frmAddCustomer_LoadGender(object sender, EventArgs e)
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
			else
			{
				int age = DateTime.Today.Year - dateBirthday.Value.Year;
				if(dateBirthday.Value.Date > DateTime.Today.AddYears(-age))
				{
					age--;
				}

				if(customer.AddCustomer(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtFirstName.Text), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtMiddleName.Text), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtLastName.Text), cmbGender.Text, age, dateBirthday.Value.Date, txtContactNumber.Text, txtEmail.Text))
				{
					MessageBox.Show("User successfully added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

					txtFirstName.ResetText();
					txtMiddleName.ResetText();
					txtLastName.ResetText();
					cmbGender.Text = null;
					dateBirthday.Value = DateTime.Today;
					txtContactNumber.ResetText();
					txtEmail.ResetText();

					txtFirstName.Focus();
				}
				else
				{
					MessageBox.Show("Failed to add customer!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Forms.Customers.frmCustomerList frmCustomerList = new frmCustomerList();
			frmCustomerList.TopLevel = false;

			Forms.frmDashboard frmDashboard1 = new Forms.frmDashboard();
			frmDashboard1.Show();

			Forms.frmDashboard frmDashboard2 = (Forms.frmDashboard)Application.OpenForms["frmDashboard"];
			Panel pnlDashboard = (Panel)frmDashboard2.Controls["pnlDashboard"];

			pnlDashboard.Controls.Add(frmCustomerList);
			frmCustomerList.Dock = DockStyle.Fill;
			frmCustomerList.Show();
			this.Close();
		}
	}
}
