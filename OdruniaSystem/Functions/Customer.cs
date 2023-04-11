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
	internal class Customer
	{
		Components.Connection con = new Components.Connection();
		Components.Value val = new Components.Value();

		public bool AddCustomer(string firstName, string middleName, string lastName, string gender, int age, DateTime birthday, string contactNumber, string email)
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

					sql = @"insert into tbl_customers(first_name, middle_name, last_name, gender_FID, age, birthday, contact_number, email)
							values(@firstName, @middleName, @lastName, @genderFID, @age, @birthday, @contactNumber, @email)";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@firstName", firstName);
						cmd.Parameters.AddWithValue("@middleName", middleName);
						cmd.Parameters.AddWithValue("@lastName", lastName);
						cmd.Parameters.AddWithValue("@genderFID", val.GenderId);
						cmd.Parameters.AddWithValue("@age", age);
						cmd.Parameters.AddWithValue("@birthday", birthday);
						cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
						cmd.Parameters.AddWithValue("@email", email);

						MySqlDataReader dr = cmd.ExecuteReader();
						dr.Close();

						connection.Close();
						return true;
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error adding customer: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
            }
		}

		public void LoadCustomers(DataGridView grid)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"select c.id, c.first_name, c.middle_name, c.last_name, g.gender, c.age, date_format(c.birthday, '%m/%d/%Y'), c.contact_number, c.email,
									date_format(c.created_at, '%m/%d/%Y'), date_format(c.updated_at, '%m/%d/%Y')
									from tbl_customers as c
									inner join tbl_genders as g on c.gender_FID = g.id
									order by c.last_name, c.first_name;";

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
						grid.Columns["date_format(c.birthday, '%m/%d/%Y')"].HeaderText = "Birthday";
						grid.Columns["contact_number"].HeaderText = "Contact Number";
						grid.Columns["email"].HeaderText = "Email";
						grid.Columns["date_format(c.created_at, '%m/%d/%Y')"].HeaderText = "CreatedAt";
						grid.Columns["date_format(c.updated_at, '%m/%d/%Y')"].HeaderText = "UpdatedAt";

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
				MessageBox.Show("Error loading customer: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public bool GetCustomer(int id)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"select c.id, c.first_name, c.middle_name, c.last_name, g.gender, c.age, c.birthday, c.contact_number, c.email
									from tbl_customers as c
									inner join tbl_genders as g on c.gender_FID = g.id
									where c.id = @id;";

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
							val.CustomerId = dt.Rows[0].Field<int>("id");
							val.CustomerFirstName = dt.Rows[0].Field<string>("first_name");
							val.CustomerMiddleName = dt.Rows[0].Field<string>("middle_name");
							val.CustomerLastName = dt.Rows[0].Field<string>("last_name");
							val.CustomerGender = dt.Rows[0].Field<string>("gender");
							val.CustomerAge = dt.Rows[0].Field<int>("age");
							val.CustomerBirthday = dt.Rows[0].Field<DateTime>("birthday");
							val.CustomerContactNumber = dt.Rows[0].Field<string>("contact_number");
							val.CustomerEmail = dt.Rows[0].Field<string>("email");

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
				MessageBox.Show("Error getting customer: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		public bool UpdateCustomer(int id, string firstName, string middleName, string lastName, string gender, int age, DateTime birthday, string contactNumber, string email)
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

					sql = @"update tbl_customers
							set first_name = @firstName, middle_name = @middleName, last_name = @lastName, email = @email, gender_FID = @genderFID, age = @age, birthday = @birthday, contact_number = @contactNumber;";

					using (MySqlCommand cmd = new MySqlCommand(sql, connection))
					{
						cmd.Parameters.AddWithValue("@id", id);
						cmd.Parameters.AddWithValue("@firstName", firstName);
						cmd.Parameters.AddWithValue("@middleName", middleName);
						cmd.Parameters.AddWithValue("@lastName", lastName);
						cmd.Parameters.AddWithValue("@email", email);
						cmd.Parameters.AddWithValue("@genderFID", val.GenderId);
						cmd.Parameters.AddWithValue("@age", age);
						cmd.Parameters.AddWithValue("@birthday", birthday);
						cmd.Parameters.AddWithValue("@contactNumber", contactNumber);

						MySqlDataReader dr = cmd.ExecuteReader();
						dr.Close();

						connection.Close();
						return true;
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error updating customer: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		public bool DeleteCustomer(int id)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(con.conString()))
				{
					string sql = @"delete
									from tbl_customers
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
				MessageBox.Show("Error deleting customer: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
	}
}
