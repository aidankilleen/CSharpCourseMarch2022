using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace UserDaoLibrary
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
            } else
            {
                // throw an exception to let the calling program know that the user doesn't exist
                rdr.Close();
                throw new UserDaoException($"User {id} not found");
            }
            rdr.Close();

            return user;
        }

        public void DeleteUser(int id)
        {
            string sql = $"delete from users where id = {id}";
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() == 0)
            {
                throw new UserDaoException($"User {id} not deleted");
            }
        }
        
        public User AddUser(User userToAdd)
        {
            string sql = @$"insert into users (name, email, active) values(@name, @email, @active)";

            Console.WriteLine(sql);
            SqlCommand cmd = new SqlCommand(sql, connection);

            SqlParameter nameParam = new SqlParameter("@name", userToAdd.Name);
            SqlParameter emailParam = new SqlParameter("@email", userToAdd.Email);
            SqlParameter activeParam = new SqlParameter("@active", userToAdd.Active ? 1 : 0);

            cmd.Parameters.Add(nameParam);
            cmd.Parameters.Add(emailParam);
            cmd.Parameters.Add(activeParam);

            cmd.ExecuteNonQuery();

            // get the id of the new user
            sql = "select @@IDENTITY";
            cmd = new SqlCommand(sql, connection);
            Decimal addedId = (Decimal)cmd.ExecuteScalar();
            userToAdd.Id = (int)addedId;
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
