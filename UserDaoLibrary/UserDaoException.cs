using System;
using System.Collections.Generic;
using System.Text;

namespace UserDaoLibrary
{
    public class UserDaoException : Exception
    {
        public UserDaoException(String message)
            :base(message)
        {

        }
    }
}
