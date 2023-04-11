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
	public partial class frmUpdateCustomer : Form
	{
		public frmUpdateCustomer()
		{
			InitializeComponent();
		}

		Components.Value val = new Components.Value();
		Functions.Customer customer = new Functions.Customer();
		Functions.Gender gender = new Functions.Gender();

		private void frmUpdateCustomer_Load(object sender, EventArgs e)
		{
			gender.LoadGendersInCmb(cmbGender);

			txtFirstName.Text = val.CustomerFirstName;
			txtMiddleName.Text = val.CustomerMiddleName;
			txtLastName.Text = val.CustomerLastName;
			cmbGender.Text = val.CustomerGender;
			dateBirthday.Text = val.CustomerBirthday.ToString("d");
			txtContactNumber.Text = val.CustomerContactNumber;
			txtEmail.Text = val.CustomerEmail;
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
			else if (String.IsNullOrWhiteSpace(cmbGender.Text))
			{
				MessageBox.Show("Gender is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (String.IsNullOrWhiteSpace(txtContactNumber.Text) && String.IsNullOrWhiteSpace(txtEmail.Text))
			{
				MessageBox.Show("Please provide contact information either contact number or email!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				int age = DateTime.Today.Year - dateBirthday.Value.Year;
				if(dateBirthday.Value.Date > DateTime.Today.AddYears(-age))
				{
					age--;
				}

				if(customer.UpdateCustomer(val.CustomerId, CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtFirstName.Text), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtMiddleName.Text), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtLastName.Text), cmbGender.Text, age, dateBirthday.Value.Date, txtContactNumber.Text, txtEmail.Text))
				{
					MessageBox.Show("Customer successfully updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Failed to update customer!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				Forms.Customers.frmCustomerList frmCustomerList = new Forms.Customers.frmCustomerList();
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

		private void btnBack_Click(object sender, EventArgs e)
		{
			Forms.Customers.frmCustomerList frmCustomerList = new Forms.Customers.frmCustomerList();
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
