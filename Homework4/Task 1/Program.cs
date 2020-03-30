using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog newDog = new Dog();
            Console.WriteLine("Whats the dogs name? ");
            newDog.name = Console.ReadLine();
            Console.WriteLine("Whats the dogs race?");
            newDog.race = Console.ReadLine();
            Console.WriteLine("Whats the dogs color?");
            newDog.color = Console.ReadLine();


            Console.WriteLine("What do want the dog to do? (eat/play/chase tail)");
            string action = Console.ReadLine();

            switch (action)
            {
                case "eat":
                    Console.WriteLine(newDog.Eat());
                    break;
                case "play":
                    Console.WriteLine(newDog.Play());
                    break;
                case "chase tail":
                    Console.WriteLine(newDog.ChaseTail());
                    break;
                default:
                    Console.WriteLine("The dog cant to that!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
