using Econtact.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econtact.Database
{
    public class DB
    {
        public static string myConnection = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        // Selecting data from DB
        public DataTable Select()
        {
            // 1. Connecting database
            SqlConnection connection = new SqlConnection(myConnection);
            DataTable dt = new DataTable();

            try
            {
                // 2. Write SQL query
                string sql = "SELECT * FROM Table_Contact";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(dt);
            } catch(Exception ex) { } finally
            {
                connection.Close();
            }
            return dt;
        }

        // Insert data to DB
        public bool Insert(Data data)
        {
            SqlConnection connection = new SqlConnection(myConnection);
            bool s = false;
            try
            {
                string sql = "INSERT INTO Table_Contact (FullName, Contact, Email, Gender) VALUES (@FullName, @Contact, @Email, @Gender)";
                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@FullName", data.FullName);
                command.Parameters.AddWithValue("@Contact", data.Contact);
                command.Parameters.AddWithValue("@Email", data.Email);
                command.Parameters.AddWithValue("@Gender", data.Gender);

                connection.Open();
                int rows = command.ExecuteNonQuery();
                s = (rows > 0);
            }
            catch (Exception ex)
            {
            } finally
            {
                connection.Close();
            }
            return s;
        }

        // Update data to DB
        public bool Update(Data data)
        {
            SqlConnection connection = new SqlConnection(myConnection);
            bool s = false;
            try
            {
                string sql = "UPDATE Table_Contact SET FullName=@FullName, Contact=@Contact, Email=@Email, Gender=@Gender WHERE Id=@Id";
                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@FullName", data.FullName);
                command.Parameters.AddWithValue("@Contact", data.Contact);
                command.Parameters.AddWithValue("@Email", data.Email);
                command.Parameters.AddWithValue("@Gender", data.Gender);
                command.Parameters.AddWithValue("@Id", data.Id);

                connection.Open();
                int rows = command.ExecuteNonQuery();
                s = (rows > 0);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return s;
        }

        // Update data to DB
        public bool Delete(Data data)
        {
            SqlConnection connection = new SqlConnection(myConnection);
            bool s = false;
            try
            {
                string sql = "DELETE FROM Table_Contact WHERE Id=@Id";
                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@Id", data.Id);

                connection.Open();
                int rows = command.ExecuteNonQuery();
                s = (rows > 0);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return s;
        }
    }
}
}
