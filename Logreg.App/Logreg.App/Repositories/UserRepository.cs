using Logreg.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logreg.App.Repositories
{
    public class UserRepository
    {
        public static List<User> users = new List<User>();

        private static int _idcount;
        public static int IdCounter
        {
            get
            {
                _idcount++;
                return _idcount;
            }
        }
        public static User AddUser(string firstname, string lastname, string password, string email)
        {
            User user = new User(firstname, lastname, password, email);
            users.Add(user);
            return user;
        }
        public static bool GetUserByEmailAndPassword(string email, string password)
        {
            foreach (User user in users)
            {
                if (Equals(user.Email, email) && Equals(user.Password, password)) ;
                {
                    return true;
                }
            }
            return false;
        }
        public static User GetUserByEmail(string email)
        {
            foreach (User user in users)
            {
                if(!Equals(user.Email, email))
                {
                    return user;
                }
                else
                {
                    Console.WriteLine("Please add correct email");
                }
            }
            return null;
        }
        public static User UpdateUser(User user,string email)
        {
            User UpdateUser = GetUserByEmail(email);
            UpdateUser.Name=user.Name;
            UpdateUser.Surname = user.Surname;
            return UpdateUser;
        }

    }

}
