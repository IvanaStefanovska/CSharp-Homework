using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            static int SumOfEven(int[] arrSix)
            {
                int result = 0;

                foreach (int i in arrSix)
                    if (i % 2 == 0)
                    {
                        result += i;
                    }
                return result;
            }

            static void Main(string[] args)
            {
                int[] arrSix = new int[6];
                for (int i = 0; i < arrSix.Length; i++)
                {
                    bool parse = int.TryParse(Console.ReadLine(), out arrSix[i]);
                }

                int result = SumOfEven(arrSix);
                Console.WriteLine("The sum of even numbers is: " + result);



                // Task 2

                string[] studentsG1 = { "Sylvanas", "Thrall", "Baine", "Voljin", "Lorthemar" };
                string[] studentsG2 = { "Anduin", "Alleria", "Jaina", "Tyrande", "Malfurion" };
                Console.WriteLine("Enter student group: (there are 1 and 2)");
                int group = 0;
                bool Result2 = int.TryParse(Console.ReadLine(), out group);


                if (group == 1)
                {
                    Console.WriteLine("StudentsG1: [Sylvanas, Thrall, Baine, Voljin, Lorthemar]");
                }
                else
                {
                    Console.WriteLine("StudentsG2: [Anduin, Alleria, Jaina, Tyrande, Malfurion]");
                }



                Console.ReadLine();
            }
        }
    }
}