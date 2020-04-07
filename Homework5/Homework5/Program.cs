using System;
using ClassLibrary;

namespace Homework5
{
    class Program
    {
        //Task 1
        //static void NumberStats(double number)
        //{
        //    bool isNegative = number < 0 ? true : false;
        //    bool isEven = number % 2 == 0 ? true : false;
        //    bool isDecimal = number % 1 > 0 ? true : false;

        //    Console.WriteLine($"Stats for number: {number}");
        //    Console.WriteLine(string.Format("{0}", isNegative ? "Negative" : "Positive"));
        //    Console.WriteLine(string.Format("{0}", isEven ? "Even" : "Odd"));
        //    Console.WriteLine(string.Format("{0}", isDecimal ? "Decimal" : "Integer"));
        //}

        //static bool UserInterface()
        //{
        //    Console.Write("Enter a number:");
        //    double number;
        //    bool isNumber = double.TryParse(Console.ReadLine(), out number);
        //    if (!isNumber)
        //    {
        //        Console.WriteLine("Not a valid number! Please try again!");
        //        return false;
        //    }
        //    NumberStats(number);
        //    Console.Write("Press any key to try again or X to exit");
        //    if (Console.ReadLine().ToUpper() == "X") return true;
        //    return false;
        //}
        //static void Main(string[] args)
        //{
        //    while (!UserInterface()) ;
        //    Console.ReadLine();

        //Task 2

        static User FindUser(User[] users, string username, string password)
        {
            foreach (User user in users)
            {
                if (user.Username.ToLower() == username.ToLower() && user.Password == password) return user;
            }
            return null;
        }
        static void Login(User[] users, string username, string password)
        {
            User user = FindUser(users, username, password);
            if (user == null)
            {
                Console.WriteLine("User not found!");
                return;
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Welcome {user.Username}!");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Your messages:");
            foreach (string message in user.messages)
            {
                Console.WriteLine(message);
            }
            Console.WriteLine("-------------------------");
        }
        static void Register(User[] users, string username, string password, int id)
        {
            User user = FindUser(users, username, password);
            if (user != null)
            {
                Console.WriteLine("User already exists!");
                return;
            }
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = new User() { Id = id, Username = username, Password = password };
            Console.WriteLine("Successfully registered!");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Users registered so far:");
            Console.WriteLine("-------------------------");
            foreach (User u in users)
            {
                Console.WriteLine($"Id: {u.Id}, Username: {u.Username}");
            }
            Console.WriteLine("-------------------------");
        }
        static bool UsersUI(User[] users)
        {
            Console.WriteLine("Choose: \n1) Log in \n2)Register");
            int choice;
            bool isNumber = int.TryParse(Console.ReadLine(), out choice);
            if (!isNumber)
            {
                Console.WriteLine("That was not a number! Try again.");
                return false;
            }
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();
                    Login(users, username, password);
                    return true;
                case 2:
                    Console.Write("Enter Id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Username: ");
                    string newUsername = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string newPassword = Console.ReadLine();
                    Register(users, newUsername, newPassword, id);
                    return true;
                default:
                    Console.WriteLine("Please enter 1 or 2");
                    return false;
            }
        }
        static void Main(string[] args)
        {
            User[] users = new User[]
            {
                new User(){Id = 24, Username = "Ivana", Password = "pass123", messages = new string[]{"Hello there Ivana!", "Call me pls!" } },
                new User(){Id = 12, Username = "Petar", Password = "123456", messages = new string[]{"How are you? Call me", "When are you coming to work?", "We should go out for a drink!" }},
                new User(){Id = 5, Username = "Anita", Password = "password", messages = new string[]{"You're invited to my bday party tomorrow!", "Do you want to adopt a dog?" }}
            };
            while (!UsersUI(users)) ;
            Console.ReadLine();
        }
    }
}
