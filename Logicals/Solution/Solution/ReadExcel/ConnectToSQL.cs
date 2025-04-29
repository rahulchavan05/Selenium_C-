using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;

namespace Logicals.ReadExcel
{
    internal class ConnectToSQL
    {

        public void Sql()
        {
            // Connection string
            string connectionString = "Server=localhost;Database=TestDB;Integrated Security=True;";

            // SQL query
            string query = "SELECT Name FROM Students";

            // Connect and read data
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["Name"].ToString());
            }

            reader.Close();
            conn.Close();
        }
    

    }
}
