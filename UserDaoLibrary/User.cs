using System;
using System.Collections.Generic;
using System.Text;

namespace UserDaoLibrary
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        public User()
        {

        }
        public User(int id, string name, string email, bool active)
        {
            Id = id;
            Name = name;
            Email = email;
            Active = active;
        }
        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Id == user.Id &&
                   Name == user.Name &&
                   Email == user.Email &&
                   Active == user.Active;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Email, Active);
        }
    }
}
