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
									inner join tbl_genders as g on u.gender_FID
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

						connection.Close();
					}
				}
			}
			catch(Exception ex)
			{
                Console.WriteLine("Error loading users: " + ex.ToString());
            }
		}
	}
}
