using Logreg.App.Models;
using Logreg.App.Repositories;

Console.WriteLine("0.Close");
Console.WriteLine("1.Register");
Console.WriteLine("2.Log in");
string Request=Console.ReadLine();
while (Request != "0")
{
    switch (Request)
    {
        case "1":
            Autentification.Register();
            break;
        case "2":
            break;
       default:
            Console.WriteLine("Please select valid option");
            break;
    }
    Console.WriteLine("0.Close");
    Console.WriteLine("1.Register");
    Console.WriteLine("2.Log in");
    Request = Console.ReadLine();
}