using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdruniaSystem.Functions
{
	internal class Gender
	{
		Components.Connection con = new Components.Connection();
		Components.Value val = new Components.Value();

		public void LoadGendersInCmb(ComboBox cmb)
		{
			try
			{
				using (MySqlConnection connectin = new MySqlConnection(con.conString()))
				{
					string sql = @"select gender
									from tbl_genders;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connectin))
					{
						connectin.Open();

						MySqlDataReader dr = cmd.ExecuteReader();

						while(dr.Read())
						{
							string gender = dr.GetString("gender");
							cmb.Items.Add(gender);
						}
					}
				}
			}
			catch(Exception ex)
			{
                Console.WriteLine("Error loading genders in combo box gender: " + ex.ToString());
            }
		}
	}
}
