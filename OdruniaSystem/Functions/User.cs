using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                Console.WriteLine("Error adding users: " + ex.ToString());
                return false;
			}
		}

		public void LoadUsers(DataGridView grid)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"select u.id, u.first_name, u.middle_name, u.last_name, g.gender, u.age,
									date_format(u.birthday, '%m/%d/%Y'), u.contact_number, u.email,
									date_format(u.created_at, '%m/%d/%Y'), date_format(u.updated_at, '%m/%d/%Y')
									from tbl_users as u
									inner join tbl_genders as g on u.gender_FID = g.id
									order by u.last_name, u.first_name;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						connection.Open();

						MySqlDataAdapter da = new MySqlDataAdapter(cmd);
						DataTable dt = new DataTable();

						dt.Clear();
						da.Fill(dt);

						grid.DataSource = dt;
						grid.ClearSelection();

						grid.Columns["id"].Visible = false;
						grid.Columns["first_name"].HeaderText = "First Name";
						grid.Columns["middle_name"].HeaderText = "Middle Name";
						grid.Columns["last_name"].HeaderText = "Last Name";
						grid.Columns["gender"].HeaderText = "Gender";
						grid.Columns["age"].HeaderText = "Age";
						grid.Columns["date_format(u.birthday, '%m/%d/%Y')"].HeaderText = "Birthday";
						grid.Columns["contact_number"].HeaderText = "Contact Number";
						grid.Columns["email"].HeaderText = "Email";
						grid.Columns["date_format(u.created_at, '%m/%d/%Y')"].HeaderText = "CreatedAt";
						grid.Columns["date_format(u.updated_at, '%m/%d/%Y')"].HeaderText = "UpdatedAt";

						foreach(DataGridViewColumn column in grid.Columns)
						{
							column.SortMode = DataGridViewColumnSortMode.NotSortable;
						}

						connection.Close();
					}
				}
			}
			catch(Exception ex)
			{
                Console.WriteLine("Error loading users: " + ex.ToString());
            }
		}

		public bool GetUser(int id)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"select u.id, u.first_name, u.middle_name, u.last_name, g.gender, u.age, u.birthday, u.contact_number, u.email, u.username
									from tbl_users as u
									inner join tbl_genders as g on u.gender_FID = g.id
									where u.id = @id;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@id", id);

						connection.Open();

						MySqlDataAdapter da = new MySqlDataAdapter(cmd);
						DataTable dt = new DataTable();

						dt.Clear();
						da.Fill(dt);

						if(dt.Rows.Count > 0)
						{
							val.UserId = dt.Rows[0].Field<int>("id");
							val.UserFirstName = dt.Rows[0].Field<string>("first_name");
							val.UserMiddleName = dt.Rows[0].Field<string>("middle_name");
							val.UserLastName = dt.Rows[0].Field<string>("last_name");
							val.UserGender = dt.Rows[0].Field<string>("gender");
							val.UserAge = dt.Rows[0].Field<int>("age");
							val.UserBirthday = dt.Rows[0].Field<DateTime>("birthday");
							val.UserContactNumber = dt.Rows[0].Field<string>("contact_number");
							val.UserEmail = dt.Rows[0].Field<string>("email");
							val.UserUsername = dt.Rows[0].Field<string>("username");

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
                Console.WriteLine("Error getting user: " + ex.ToString());
				return false;
            }
		}
	}
}
