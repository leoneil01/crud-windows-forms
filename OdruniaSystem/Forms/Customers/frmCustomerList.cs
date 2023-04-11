using OdruniaSystem.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdruniaSystem.Forms.Customers
{
	public partial class frmCustomerList : Form
	{
		public frmCustomerList()
		{
			InitializeComponent();
		}

		Functions.Customer customer = new Functions.Customer();

		private void frmCustomerList_LoadCustomer(object sender, EventArgs e)
		{
			customer.LoadCustomers(gridCustomers);
		}

		private void frmCustomerList_VisibleChanged(object sender, EventArgs e)
		{
			gridCustomers.ClearSelection();
		}

		private void btnAddCustomer_Click(object sender, EventArgs e)
		{
			Forms.Customers.frmAddCustomer frmAddCustomer = new frmAddCustomer();
			frmAddCustomer.Show();
			Application.OpenForms["frmDashboard"].Close();
		}

		private void btnViewCustomer_Click(object sender, EventArgs e)
		{
			if (gridCustomers.SelectedRows.Count < 1)
			{
				MessageBox.Show("Select customer first!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (customer.GetCustomer(int.Parse(gridCustomers.SelectedCells[0].Value.ToString())))
			{
				Forms.Customers.frmViewCustomer frmViewCustomer = new frmViewCustomer();
				frmViewCustomer.Show();
				Application.OpenForms["frmDashboard"].Close();
			}
		}

		private void btnUpdateCustomer_Click(object sender, EventArgs e)
		{
			if (gridCustomers.SelectedRows.Count < 1)
			{
				MessageBox.Show("Select customer first!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (customer.GetCustomer(int.Parse(gridCustomers.SelectedCells[0].Value.ToString())))
			{
				Forms.Customers.frmUpdateCustomer frmUpdateCustomer = new frmUpdateCustomer();
				frmUpdateCustomer.Show();
				Application.OpenForms["frmDashboard"].Close();
			}
		}

		private void btnDeleteCustomer_Click(object sender, EventArgs e)
		{
			if(gridCustomers.SelectedRows.Count < 1)
			{
				MessageBox.Show("Select user first!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(MessageBox.Show("Are you sure you want to delete this customer?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (customer.DeleteCustomer(int.Parse(gridCustomers.SelectedCells[0].Value.ToString())) )
				{
					MessageBox.Show("Customer succesfully deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					customer.LoadCustomers(gridCustomers);
				}
				else
				{
					MessageBox.Show("Failed to delete customer!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
