using Logreg.App.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Logreg.App.Models
{
    public class Autentification
    {
  
        
        public  static void Register()
        {
            string name = GetName();
            string surname = GetSureName();
            string email = GetEmail();
            string password = GetPassword();
            if (UserValidation.CheckName(name) & UserValidation.CheckSurname(surname) & UserValidation.CheckEmail(email) )
            {
                User user = UserRepository.AddUser(name,surname,email,password);
                Console.WriteLine($"User added to system, his/her details are : {user.GetInfo()}");
            }
            
        }
        public void Login()
        {
            Console.WriteLine("Please enter Email:  ");
            string email= Console.ReadLine();
            Console.WriteLine("Please enter password:   ");
            string password= Console.ReadLine();
            if (UserRepository.GetUserByEmailAndPassword(email, password))
            {
                User user = UserRepository.GetUserByEmail(email);
                Dashboard.CurrentUser = user;
                if (user is Admin)
                {
                    Dashboard.AdminPanel();
                }
                else if(user is User)
                {
                    Dashboard.UserPanel();
                }
            }
        }

        public static string GetName()
        {
            Console.WriteLine("Add Name");
            string name = Console.ReadLine();
            while (!UserValidation.CheckName(name))
            {
                Console.WriteLine("Please add valid name");
                name = Console.ReadLine();

            }
            return name;
        }
        public static string GetSureName()
        {
            Console.WriteLine("Add SurName");
            string sureName = Console.ReadLine();
            while (!UserValidation.CheckSurname(sureName))
            {
                Console.WriteLine("Please add valid surname");
                sureName = Console.ReadLine();
            }
            return sureName;
        }
        public static string GetEmail()
        {
            string email = Console.ReadLine();
            while (!UserValidation.CheckEmail(email))
            {
                Console.WriteLine("Please add valid email");
                email = Console.ReadLine();
            }
            return email;
        }
        public static string GetPassword()
        {
            string password = Console.ReadLine();
            string confirmpassword = Console.ReadLine();
            while (!UserValidation.CheckPassword(password, confirmpassword))
            {
                Console.WriteLine("Please add valid passwords");
                password = Console.ReadLine();
                confirmpassword = Console.ReadLine();
            }
            return password;
        }

    }


}
