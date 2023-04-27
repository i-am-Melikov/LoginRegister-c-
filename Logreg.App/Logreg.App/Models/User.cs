using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logreg.App.Models
{
    public class User
    {
        private int _id;

        public User()
        {
        }
        public User(string name, string surname)
        {

        }
        public User(string firstname, string lastname, string password, string email)
        {
            Name = firstname;
            Surname = lastname;
            Password = password;
            Email = email;
        }
        public virtual string GetInfo()
        {
            return $"Hello user : {Name}:   {Surname}";
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
