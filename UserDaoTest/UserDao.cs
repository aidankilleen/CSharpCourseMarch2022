using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace UserDaoTest
{
    class UserDao
    {
        private SqlConnection connection;
        private string connectionString = "Server=tcp:professionaltraining.database.windows.net,1433;Initial Catalog=XmlTestDb;Persist Security Info=False;User ID=ptuser;Password=<>;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public UserDao()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();

            string sql = "select * from users";

            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                int id = rdr.GetInt32(rdr.GetOrdinal("id"));
                string name = rdr.GetString(rdr.GetOrdinal("name"));
                string email = rdr.GetString(rdr.GetOrdinal("email"));
                bool active = rdr.GetInt32(rdr.GetOrdinal("active")) == 1;

                User u = new User(id, name, email, active);

                users.Add(u);
            }
            rdr.Close();
            return users;
        }


        public User GetUser(int id)
        {
            User user = null;

            string sql = $"select * from users where id = {id}";

            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                string name = rdr.GetString(rdr.GetOrdinal("name"));
                string email = rdr.GetString(rdr.GetOrdinal("email"));
                bool active = rdr.GetInt32(rdr.GetOrdinal("active")) == 1;

                user = new User(id, name, email, active);
            }
            rdr.Close();
            return user;
        }

        public void DeleteUser(int id)
        {
            string sql = $"delete from users where id = {id}";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
        }

        
        public User AddUser(User userToAdd)
        {
            string sql = @$"insert into users 
                 (name, email, active)
                 values('{ userToAdd.Name }', 
                        '{ userToAdd.Email }', 
                        { (userToAdd.Active ? 1 : 0) })";

            Console.WriteLine(sql);

            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();

            // TBD - get the id of the new user

            return userToAdd;
        }
        

        public User UpdateUser(User userToUpdate)
        {
            string sql = @$"update users 
                            set name = '{userToUpdate.Name}', 
                                email = '{userToUpdate.Email}',
                                active = {(userToUpdate.Active ? 1 : 0)}
                            where id = {userToUpdate.Id}";

            // Console.WriteLine(sql);

            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();

            return userToUpdate;
        }



        public void Close()
        {
            connection.Close();
        }

    }
}
