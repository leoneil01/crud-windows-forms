using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdruniaSystem.Functions
{
	internal class Login
	{
		Components.Connection con = new Components.Connection();
		Components.Value val = new Components.Value();

		public bool AuthenticateUser(string username, string password)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"select u.id, u.first_name, u.middle_name, u.last_name, g.gender, u.age, u.birthday, u.contact_number, u.email, u.username
									from tbl_users as u
									inner join tbl_genders as g on u.gender_FID = g.id
									where u.username = @username and u.password = MD5(@password);";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@username", username);
						cmd.Parameters.AddWithValue("@password", password);

						connection.Open();

						MySqlDataAdapter da = new MySqlDataAdapter(cmd);
						DataTable dt = new DataTable();

						dt.Clear();
						da.Fill(dt);

						if(dt.Rows.Count > 0)
						{
							val.MyId = dt.Rows[0].Field<int>("id");
							val.MyFirstName = dt.Rows[0].Field<string>("first_name");
							val.MyMiddleName = dt.Rows[0].Field<string>("middle_name");
							val.MyLastName = dt.Rows[0].Field<string>("last_name");
							val.MyGender = dt.Rows[0].Field<string>("gender");
							val.MyBirthday = dt.Rows[0].Field<DateTime>("birthday");
							val.MyContactNumber = dt.Rows[0].Field<string>("contact_number");
							val.MyEmail = dt.Rows[0].Field<string>("email");
							val.MyUsername = dt.Rows[0].Field<string>("username");

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
                Console.WriteLine("Error authenticating user: " + ex.ToString());
				return false;
            }
		}
	}
}
