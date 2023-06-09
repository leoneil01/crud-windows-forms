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
	internal class User
	{
		Components.Connection con = new Components.Connection();
		Components.Value val = new Components.Value();

		public bool AddUser(string firstName, string middleName, string lastName, string gender, int age, DateTime birthday, string contactNumber, string email, string username, string password, byte[] profilePicture)
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

					sql = @"insert into tbl_users(first_name, middle_name, last_name, gender_FID, age, birthday, contact_number, email, username, password, profile_picture)
							values (@firstName, @middleName, @lastName, @genderFID, @age, @birthday, @contactNumber, @email, @username, MD5(@password), @profilePicture);";

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
						cmd.Parameters.AddWithValue("@profilePicture", profilePicture);

						MySqlDataReader dr = cmd.ExecuteReader();
						dr.Close();

						connection.Close();
						return true;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error adding users: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
									date_format(u.created_at, '%m/%d/%Y'), date_format(u.updated_at, '%m/%d/%Y'),
									u.profile_picture
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
						grid.Columns["profile_picture"].HeaderText = "User Picture";

						DataGridViewImageColumn clmProfilePicture = new DataGridViewImageColumn();
						clmProfilePicture = (DataGridViewImageColumn)grid.Columns["profile_picture"];
						clmProfilePicture.ImageLayout = DataGridViewImageCellLayout.Stretch;

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
				MessageBox.Show("Error loading users: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public bool GetUser(int id)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"select u.id, u.first_name, u.middle_name, u.last_name, g.gender, u.age, u.birthday, u.contact_number, u.email, u.username, u.profile_picture
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
							val.UserPicture = dt.Rows[0].Field<byte[]>("profile_picture");

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
				MessageBox.Show("Error getting users: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		public bool UpdateUser(int id, string firstName, string middleName, string lastName, string gender, int age, DateTime birthday, string contactNumber, string email, string username, byte[] profilePicture)
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

					sql = @"update tbl_users
							set first_name = @firstName, middle_name = @middleName, last_name = @lastName, gender_FID = @genderFID, age = @age, birthday = @birthday, contact_number = @contactNumber, email = @email, username = @username, updated_at = current_timestamp, profile_picture = @profilePicture
							where id = @id;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@id", id);
						cmd.Parameters.AddWithValue("@firstName", firstName);
						cmd.Parameters.AddWithValue("@middleName", middleName);
						cmd.Parameters.AddWithValue("@lastName", lastName);
						cmd.Parameters.AddWithValue("@genderFID", val.GenderId);
						cmd.Parameters.AddWithValue("@age", age);
						cmd.Parameters.AddWithValue("@birthday", birthday);
						cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
						cmd.Parameters.AddWithValue("@email", email);
						cmd.Parameters.AddWithValue("@username", username);
						cmd.Parameters.AddWithValue("@profilePicture", profilePicture);

						MySqlDataReader dr = cmd.ExecuteReader();
						dr.Close();

						connection.Close();
						return true;
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error updating users: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		public bool DeleteUser(int id)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"delete
									from tbl_users
									where id = @id;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@id", id);

						connection.Open();

						MySqlDataReader dr = cmd.ExecuteReader();
						dr.Close();

						connection.Close();
						return true;
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error deleting users: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
	}
}
