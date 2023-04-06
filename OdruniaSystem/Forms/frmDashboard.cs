using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdruniaSystem.Forms
{
	public partial class frmDashboard : Form
	{
		public frmDashboard()
		{
			InitializeComponent();
		}

		private void btnUsers_Click(object sender, EventArgs e)
		{
			pnlDashboard.Controls.Clear();
			Forms.Users.frmUserList frmUserList = new Forms.Users.frmUserList();
			frmUserList.TopLevel = false;
			pnlDashboard.Controls.Add(frmUserList);
			frmUserList.Dock = DockStyle.Fill;
			frmUserList.Show();
			//this.Close();
		}
	}
}
