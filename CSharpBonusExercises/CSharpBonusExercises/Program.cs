using System;

namespace CSharpBonusExercises
{
    class Program
    {
        public static void Main()
        {
            /*Task 1

            Console.WriteLine("The Sum of  first 10 natural numbers");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
            Console.ReadLine();

            //Task 2

            int sum = 0;
            int[] num = new int[10];
            Console.WriteLine("Enter 10 numbers from keyboard and find their sum and average");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                sum = sum + num[i];
            }
            Console.WriteLine("The sum of the numbers is: {0}", sum);
            int aveg;
            aveg = sum / 10;
            Console.WriteLine("The average is {0}", aveg);
            Console.ReadLine();

            //Task 3


            int[] array = new int[] { 6, 3, 5, 10, 2, 11, 13, 1, 8, 9 };

            int max=array[0];
            int min=array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
               {
                   min = array[i];
                }
            }
            
            int indexMax = Array.IndexOf(array, max);
            int indexMin = Array.IndexOf(array, min);
            Console.WriteLine($"The maximum element in the array is:{max} and it's index is:{indexMax}");
            Console.WriteLine($"The minimum element in the array is:{min} and it's index is:{indexMin}");

            Console.ReadLine();

            //Task 4

            int[] arrayWithDuplicates = new int[] { 1, 4, 6, 3, 4, 5, 9, 3, 2, 9 };
            int count = 0;
            int[] arr = new int [] { };
         
            for (int i = 0; i < arrayWithDuplicates.Length; i++)
            {
              for (int j = i + 1; j < arrayWithDuplicates.Length; j++)
                {
                  if (arrayWithDuplicates[i] == arrayWithDuplicates[j] && Array.IndexOf(arr, arrayWithDuplicates[i]) == -1)
                    {
                      Array.Resize(ref arr, arr.Length + 1);
                       arr[arr.Length - 1] = arrayWithDuplicates[i];
                       count++;
                       break;
                    }
                }
            }
            Console.WriteLine($"The total number of duplicate elements in arrayWithDuplicates is: {count}");

            Console.ReadLine();

            //Task 6

            Console.WriteLine("Enter number between 1 and 7!");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Please enter a number between 1 and 7");
                    break;
            }

            Console.ReadLine();*/

            // Task 7

            string[] userNames = { "user1", "user2", "user3" };
            string[] passwords = { "first", "second", "third" };

            while (true)
            {
                Console.WriteLine("Please enter your username:");
                string userInput = (Console.ReadLine());
                Console.WriteLine("Please enter your password:");
                string passInput = (Console.ReadLine());

                if (userInput == userNames[0] && passInput == passwords[0])
                {
                    Console.WriteLine("You are logged in successfully!");
                    break;
                }
                else if (userInput == userNames[1] && passInput == passwords[1])
                {
                    Console.WriteLine("You are logged in successfully!");
                    break;
                }
                else if (userInput == userNames[2] && passInput == passwords[2])
                {
                    Console.WriteLine("You are logged in successfully!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect username or password!");
                }
            }

            Console.ReadLine();
        }
    }
}
