using Homework7.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPhoneBook = new PhoneBook();
            bool askAgain = true;
            while (askAgain)
            {

                Console.WriteLine($"Search for name in phonebook:");
                string userInput = Console.ReadLine();
                var empty = string.IsNullOrEmpty(userInput);
                if (empty)
                {
                    Console.WriteLine("You must enter a name! Do you whant to continue Y/n");
                    var userInput2 = Console.ReadLine();
                    if (userInput2 == "n" || userInput2 == "N")
                    {
                        askAgain = false;
                        break;
                    }
                    break;
                }

                var isfound = myPhoneBook.phoneBook.ContainsKey(userInput);
                if (isfound)
                {
                    Console.WriteLine($"The {userInput}  number is : {myPhoneBook.phoneBook[userInput]}");
                }
                else
                {
                    Console.WriteLine($"That name is not found in phonebook");
                }

                Console.WriteLine("Do you whant another search? Y/n");
                var userInput3 = Console.ReadLine();
                if (userInput3 == "n" || userInput3 == "N")
                {
                    askAgain = false;
                    break;
                }

                askAgain = true;
            }
        }
    }
}
