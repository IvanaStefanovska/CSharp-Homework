using System;

namespace Homework3
{
    class Program
    {

        //static void Substrings()
        //{
        //    //Task 1

        //    string myString = "Hello from SEDC Codecademy v7.0";
        //    Console.WriteLine("Hello from SEDC Codecademy v7.0");
        //    Console.WriteLine($"Please enter one number from 1 to {myString.Length}");

        //    bool inputNumber = int.TryParse(Console.ReadLine(), out int number);

        //    if (!inputNumber)
        //    {
        //        Console.WriteLine("Please enter a number");
        //    }
        //    else if (number < 1 || number > myString.Length)
        //    {
        //        Console.WriteLine("Please enter a correct number");
        //    }
        //    else
        //    {
        //        string nCharacter = myString.Substring(0, number);
        //        Console.WriteLine($"The new string is {nCharacter}.");
        //        Console.WriteLine($"The lenght of the new string is: {nCharacter.Length}");
        //    }

        //    Console.ReadLine();
        //}
        //static void Main(string[] args)
        //{
        //    Substrings();
        //}

        //Task 2
        public static void Main(string[] args)
        {
            ////Print the date that is 3 days from now
            ////Print the date that is one month from now
            ////Print the date that is one month and 3 days from now
            ////Print 1 year and 2 months ago from today
            ////Print only the current month with words
            ////Print only the current year

            //DateTime Today = DateTime.Now;

            //Console.WriteLine(Today.AddDays(3));
            //Console.WriteLine(Today.AddMonths(1));
            //Console.WriteLine(Today.AddMonths(1).AddDays(3));
            //Console.WriteLine(Today.AddYears(1).AddMonths(2));
            //Console.WriteLine(Today.ToString("MMMM"));
            //Console.WriteLine(Today.Year);

            //Console.ReadLine();

            //Task 3

            Console.Write("Enter day of birth: ");
            int InputDay = int.Parse(Console.ReadLine());
            Console.Write("Enter month of birth: ");
            int InputMonth = int.Parse(Console.ReadLine());
            Console.Write("Enter year of birth: ");
            int InputYear = int.Parse(Console.ReadLine());

            DateTime Birthday = new DateTime(InputYear, InputMonth, InputDay);

            Console.WriteLine($"You are {AgeCalculator(Birthday)} years old.");
            Console.ReadLine();
        }

        public static int AgeCalculator(DateTime birthday)
        {
            DateTime Today = DateTime.Now;

            if (birthday.Month > Today.Month)
            {
                return Today.Year - (birthday.Year + 1);
            }
            else if (birthday.Month == Today.Month)
            {
                if (birthday.Day > Today.Day)
                {
                    return Today.Year - (birthday.Year + 1);
                }
                else if (birthday.Day == Today.Day)
                {
                    Console.WriteLine("Happy birthday!!!");
                }
            }
            return Today.Year - birthday.Year;
        }
    }
}
