using System;
using System.Data.SqlClient;

namespace HelloWorldDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World DB");

            // Connection String
            string connectionString = "Server=tcp:professionaltraining.database.windows.net,1433;Initial Catalog=XmlTestDb;Persist Security Info=False;User ID=ptuser;Password=Training2022#@!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            // sql query
            string sql = "select * from users";

            // use Command to execute the query to retrieve a SqlDataReader
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader rdr = cmd.ExecuteReader();

            // step through the contents of the SqlDataReader
            while(rdr.Read())
            {
                int id = rdr.GetInt32(rdr.GetOrdinal("id"));
                string name = rdr.GetString(rdr.GetOrdinal("name"));
                string email = rdr.GetString(rdr.GetOrdinal("email"));
                bool active = rdr.GetInt32(rdr.GetOrdinal("active")) == 1;
                Console.WriteLine($"{id} {name} {email} {active}");
            }
            // close the statement & connection
            rdr.Close();


            // test doing an update query

            sql = "insert into users (name, email, active) values('Jane', 'jane@gmail.com', 1)";

            cmd = new SqlCommand(sql, connection);

            cmd.ExecuteNonQuery();

            

            connection.Close();
        }
    }
}
