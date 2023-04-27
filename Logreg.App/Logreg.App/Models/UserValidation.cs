using Logreg.App.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Logreg.App.Models
{
    public class UserValidation
    {
        public static bool CheckName(string name)
        {
            if (name.Length < 30 && name.Length > 3)
            {
                return true;
            }
            Console.WriteLine("Enter name which length is between 3 and 30");
            return false;
        }
        public static bool CheckSurname(string surname)
        {
            if (surname.Length < 30 && surname.Length > 3)
            {
                return true;
            }
            Console.WriteLine("Enter surname which length is between 5 and 20");
            return false;
        }
        public static bool CheckEmail(string email)
        {
            string rg=@"/ ([a - zA - Z0 - 9\.] +)@([a - z 0 - 9\.] +)\.([a - z] +)$/ gm";
            Regex regex = new Regex(rg);
            if (regex.IsMatch(email))
            {
                return true;
            }
            Console.WriteLine("Please write valid mail");
            return false;
        }
        public static bool CheckPassword(string password, string confirmpassword)
        {
            if(password== confirmpassword)
            {
                return true;
            }
            Console.WriteLine("Please add valid password");
            return false;
        }


    }
}
