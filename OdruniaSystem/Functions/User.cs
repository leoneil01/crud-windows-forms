using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdruniaSystem.Functions
{
	internal class User
	{
		Components.Connection con = new Components.Connection();
		Components.Value val = new Components.Value();

		public bool AddUser(string firstName, string middleName, string lastName, string gender, int age, DateTime birthday, string contactNumber, string email, string username, string password)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"select id
									from tbl_genders
									where gender = @gender;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@gender", gender);

						connection.Open();

						MySqlDataAdapter da = new MySqlDataAdapter(cmd);
						DataTable dt = new DataTable();

						dt.Clear();
						da.Fill(dt);

						val.GenderId = dt.Rows[0].Field<int>("id");
					}

					sql = @"insert into tbl_users(first_name, middle_name, last_name, gender_FID, age, birthday, contact_number, email, username, password)
							values (@firstName, @middleName, @lastName, @genderFID, @age, @birthday, @contactNumber, @email, @username, MD5(@password));";

					using (MySqlCommand cmd = new MySqlCommand(@sql, connection))
					{
						cmd.Parameters.AddWithValue("@firstName", firstName);
						cmd.Parameters.AddWithValue("@middleName", middleName);
						cmd.Parameters.AddWithValue("@lastName", lastName);
						cmd.Parameters.AddWithValue("@genderFID", val.GenderId);
						cmd.Parameters.AddWithValue("@age", age);
						cmd.Parameters.AddWithValue("@birthday", birthday);
						cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
						cmd.Parameters.AddWithValue("@email", email);
						cmd.Parameters.AddWithValue("@username", username);
						cmd.Parameters.AddWithValue("@password", password);

						MySqlDataReader dr = cmd.ExecuteReader();
						dr.Close();

						connection.Close();
						return true;
					}
				}
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
