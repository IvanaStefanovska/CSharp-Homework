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

            Console.ReadLine();*/

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
        }
    }
}
