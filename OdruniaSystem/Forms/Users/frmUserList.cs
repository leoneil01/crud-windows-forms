using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdruniaSystem.Forms.Users
{
	public partial class frmUserList : Form
	{
		public frmUserList()
		{
			InitializeComponent();
		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			Forms.Users.frmAddUser frmAddUser = new Forms.Users.frmAddUser();
			frmAddUser.Show();
			Application.OpenForms["frmDashboard"].Close();
		}
	}
}
