using Logreg.App.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Logreg.App.Models
{
    public class Dashboard 
    {
        public static User CurrentUser { get; set; }
        public static void AdminPanel()
        {
            Console.WriteLine("0.Close");
            Console.WriteLine("1.Add user");
            Console.WriteLine("2.Update user");
            string Request = Console.ReadLine();
            while (Request != "0")
            {
                if (Request == "1")
                {
                    Autentification.Register();
                    break;
                }
                if (Request == "2")
                {

                    while (true)
                    {
                        string email = Console.ReadLine();
                        User user = UserRepository.GetUserByEmail(email);
                        if (user == null)
                        {
                            Console.WriteLine("There is no one registered with this email,please add correct email");

                        }
                        else if (user is Admin)
                        {
                            Console.WriteLine("This is admin,you cannot update admin");
                        }
                        User UpdateUser= new User(Autentification.GetName(),Autentification.GetSureName());
                        UserRepository.UpdateUser(UpdateUser,email);
                        Console.WriteLine("User has been successfully updated");
                    }
                }
                else
                {

                    Console.WriteLine("A user NOT added");
                    break;
                }
            }
        }
        public static void UserPanel()
        {

        }
    }
}
