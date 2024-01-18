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
            try
            {
                string sql = "INSERT INTO Table_Contact";

            }
            catch (Exception ex)
            {

            } finally
            {

            }
        }
    }
}
