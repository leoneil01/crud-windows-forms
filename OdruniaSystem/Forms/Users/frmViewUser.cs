﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OdruniaSystem.Forms.Users
{
	public partial class frmViewUser : Form
	{
		public frmViewUser()
		{
			InitializeComponent();
		}

		Components.Value val = new Components.Value();

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

		private void frmViewUser_Load(object sender, EventArgs e)
		{
			if (val.UserPicture != null)
			{
				MemoryStream ms = new MemoryStream(val.UserPicture);
				pbUserPicture.Image = Image.FromStream(ms);
			}

			txtFirstName.Text = val.UserFirstName;
			txtMiddleName.Text = val.UserMiddleName;
			txtLastName.Text = val.UserLastName;
			txtEmail.Text = val.UserEmail;
			txtGender.Text = val.UserGender;
			txtBirthday.Text = val.UserBirthday.ToString("d");
			txtContactNumber.Text = val.UserContactNumber;
			txtAge.Text = val.UserAge.ToString();
			txtUsername.Text = val.UserUsername;
		}
	}
}
