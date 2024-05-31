// See https://aka.ms/new-console-template for more information
using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Virtual Pet Simulator!");
            Console.WriteLine("Choose a pet type of your choice(e.g., cat, dog, rabbit): ");
            string petType = Console.ReadLine();
            Console.WriteLine("Give your pet a name of your liking: ");
            string petName = Console.ReadLine();
            Pet myPet = new Pet(petName, petType);

            Console.WriteLine($"Welcome, {myPet.Name} the {myPet.Type}!");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nWhat would you like to do with your pet from the given options? (Feed/Play/Rest/Status/Exit): ");
                string action = Console.ReadLine().ToLower();

                switch (action)
                {
                    case "feed":
                        myPet.Feed();
                        break;
                    case "play":
                        myPet.Play();
                        break;
                    case "rest":
                        myPet.Rest();
                        break;
                    case "status":
                        myPet.CheckStatus();
                        // Console.WriteLine($"Pet Stats: \nName: {myPet.Name} \nType: {myPet.Type} \nHunger: {myPet.Hunger} \nHappiness: {myPet.Happiness} \nHealth: {myPet.Health}");
                        break;
                    case "exit":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid action. Please choose from the options (either feed, play, rest, status) or exit.");
                        break;

                }

            }

            Console.WriteLine("Thank you for playing! Hope you had a great time with your VirtualPet ");
        }
    }
}

