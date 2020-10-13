using System;
using System.Collections.Generic;
using ÖvningSamlingarLoopar.Entities;

namespace ÖvningSamlingarLoopar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange era djur: ");
            List<Animal> animals = new List<Animal>();

            bool userHasEnteredAllAnimals = false;

            while (userHasEnteredAllAnimals == false)
            {
                Console.WriteLine("Vill du skriva in ett djur? J/N");
                string response = Console.ReadLine();

                if (string.IsNullOrEmpty(response) == false)
                {
                    response = response.ToLower();
                }
                else
                {
                    response = string.Empty;
                }

                if (response != "n")
                {
                    Animal animal = GetInformationOfAnimal();

                    if (animal == null)
                    {
                        Console.WriteLine("Du angav något felaktigt, försök igen!");
                        continue;
                    }
                    animals.Add(animal);
                }
                else
                {
                    userHasEnteredAllAnimals = true;
                }
            }
            bool userIsCommunicatingWithAnimals = true;

            while (userIsCommunicatingWithAnimals == true)
            {
                Console.Write("(Alla djuren i kör) Vad ska vi göra nu??? namn/ålder/äta/springa");
                string response = Console.ReadLine();
                if (string.IsNullOrEmpty(response) == false)
                {
                    response = response.ToLower();
                }
                else
                {
                    response = string.Empty;
                }
                switch (response)
                {
                    case "namn":
                        WriteAllNames(animals);
                        break;
                    case "ålder":
                        WriteAllAges(animals);
                        break;
                    case "äta":
                        WriteAllEat(animals);
                        break;
                    case "springa":
                        WriteAllRun(animals);
                        break;
                    default:
                        break;
                }
            }
        }
        private static void WriteAllEat(List<Animal> animals)
        {
            int animalNr = 1;
            foreach (var animal in animals)
            {
                Console.WriteLine($"Djur nr {animalNr} äter:");
                animal.Eat();
                animalNr++;
            }
        }
        private static void WriteAllAges(List<Animal> animals)
        {
            int animalNr = 1;

            foreach (var animal in animals)
            {
                int ageOfAnimal = animal.GetAge();
                Console.WriteLine($"Djur nr {animalNr} omräknade ålder är: {ageOfAnimal}");
                animalNr++;
            }
        }
        private static void WriteAllRun(List<Animal> animals)
        {
            int animalNr = 1;
            foreach (var animal in animals)
            {
                Console.WriteLine($"Djur nr {animalNr} springer: ");
                animal.Run();
                animalNr++;
            }
        }
        private static void WriteAllNames(List<Animal> animals)
        {
            int animalNr = 1;
            foreach (var animal in animals)
            {
                Console.WriteLine($"Djur nr {animalNr} heter: {animal.Name}");
                animalNr++;
            }
        }
        private static Animal GetInformationOfAnimal()
        {
            Console.Write("Vilken art? hund/katt/kanin");
            string responseSpecies = Console.ReadLine();
            responseSpecies = responseSpecies.ToLower();

            Animal animal;

            switch (responseSpecies)
            {
                case "hund":
                    animal = new Dog();
                    break;
                case "katt":
                    animal = new Cat();
                    break;
                case "kanin":
                    animal = new Rabbit();
                    break;
                default:
                    return null;
            }
            Console.Write("Vad heter djuret?: ");
            string responseName = Console.ReadLine();

            animal.Name = responseName;

            Console.Write("Hur gammal är djuret?: ");
            string responseAge = Console.ReadLine();

            bool parsedSuccesfully = int.TryParse(responseAge, out int age);

            if (parsedSuccesfully == true)
            {
                animal.Age = age;
            }
            else
            {
                return null;
            }
            return animal;
        }
    }
}
