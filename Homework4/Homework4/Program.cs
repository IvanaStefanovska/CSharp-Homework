using System;
using Homework4.Classes;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a dog's name:");
            string name = Console.ReadLine();
            Console.WriteLine("Now enter the dog's color:");
            string color = Console.ReadLine();
            Console.WriteLine("Enter the dog's race:");
            string race = Console.ReadLine();
            Console.WriteLine("Now choose what you would want the dog to do: Play, Eat or Chasetail");
            string action = Console.ReadLine();


            Dog dog = new Dog()
            {
                Name = name,
                Color = color,
                Race = race,

            };

            if (action == "Play")
            {
                Console.WriteLine(dog.Play());

            }
            else if (action == "Eat")
            {
                Console.WriteLine(dog.Eat());
            }
            else if (action == "ChaseTail")
            {
                Console.WriteLine(dog.ChasingTail());
            }
            else
            {
                Console.WriteLine("Invalid input");
            }


            Console.ReadLine();

        }
    }
}
