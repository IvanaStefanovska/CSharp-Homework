using System;
using PetStoreApp.Entities;

namespace PetStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PetStore<Dog> dogStore = new PetStore<Dog>();
            PetStore<Cat> catStore = new PetStore<Cat>();
            PetStore<Fish> fishStore = new PetStore<Fish>();

            static void Main(string[] args, PetStore<Dog> dogStore, PetStore<Cat> catStore, PetStore<Fish> fishStore)
            {
                dogStore.Pets.Add(new Dog("Bruno", 8, true, "Bone"));
                dogStore.Pets.Add(new Dog("Aron", 5, false, "Steak"));
                catStore.Pets.Add(new Cat("Maca", 10, false, 9));
                catStore.Pets.Add(new Cat("Tom", 4, true, 7));
                fishStore.Pets.Add(new Fish("Nemo", 0, "Gold", 1));
                fishStore.Pets.Add(new Fish("Sharky", 1, "Blue", 2));

                dogStore.BuyPet("Aron");
                catStore.BuyPet("Maca");

                dogStore.PrintPets();
                catStore.PrintPets();
                fishStore.PrintPets();

                Console.ReadLine();
            }
        }
    }
}
