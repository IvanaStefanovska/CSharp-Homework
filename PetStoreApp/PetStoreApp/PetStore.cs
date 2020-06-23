﻿using PetStoreApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetStoreApp
{
	public class PetStore<T> where T : Pet
	{

		public List<T> Pets;
		public PetStore()
		{
			Pets = new List<T>();
		}
		public void PrintPets()
		{
			foreach (T pet in Pets)
			{
				Console.WriteLine(pet.PrintInfo());
			}
		}
		public void BuyPet(string name)
		{
			T pet = Pets.FirstOrDefault(x => x.Name == name);
			if (pet == null)
			{
				Console.WriteLine("There's no pet with that name!");
				return;
			}
			Pets.Remove(pet);
			Console.WriteLine($"You bought a pet named {pet.Name}");

		}
	}
}
