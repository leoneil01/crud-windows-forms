﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdruniaSystem.Functions
{
	internal class Check
	{
		Components.Connection con = new Components.Connection();
		Components.Value val = new Components.Value();

		public bool IsUsernameExists(string username)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"select username 
									from tbl_users
									where username = @username;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@username", username);

						connection.Open();

						MySqlDataAdapter da = new MySqlDataAdapter(cmd);
						DataTable dt = new DataTable();

						dt.Clear();
						da.Fill(dt);

						if(dt.Rows.Count > 0)
						{
							connection.Close();
							return true;
						}
						else
						{
							connection.Close();
							return false;
						}
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error checking username: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
            }
		}
	}
}
