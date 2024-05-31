///main program
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
            int hoursPassed = 0;

            Console.WriteLine($"Welcome, {myPet.Name} the {myPet.Type}!");

           // Timer timer = new Timer(TimePasses, null, 0, 3600000);//3600000 millisecs is an hour
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

                hoursPassed++;
                Console.WriteLine($"Hours passed: {hoursPassed}");
               myPet.TimePasses();
               //myPet.CheckStatus();

            }

            Console.WriteLine("Thank you for playing! Hope you had a great time with your VirtualPet ");
        }

       /* static void TimePasses(object state)
        {
            // Simulate time passing every hour
            Console.WriteLine("\nTime passes...");
            Pet pet = new Pet("Placeholder", "Placeholder"); // Replace with actual pet instance
            pet.TimePasses();
            pet.CheckStatus();
        }*/
    }
}

