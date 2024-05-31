using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Virtual Pet Simulator!");
            Console.WriteLine("Choose a pet type (e.g., cat, dog, rabbit): ");
            string petType = Console.ReadLine();
            Console.WriteLine("Give your pet a name: ");
            string petName = Console.ReadLine();
            Pet myPet = new Pet(petName, petType);

            Console.WriteLine($"Welcome, {myPet.Name} the {myPet.Type}!");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nWhat would you like to do with your pet? (feed/play/rest/status/exit): ");
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
                        Console.WriteLine($"Pet Stats: \nName: {myPet.Name} \nType: {myPet.Type} \nHunger: {myPet.Hunger} \nHappiness: {myPet.Happiness} \nHealth: {myPet.Health}");
                        break;
                    case "exit":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid action. Please choose either feed, play, rest, status, or exit.");
                        break;
                }

                // Simulate passage of time
                myPet.Hunger = Math.Min(myPet.Hunger + 1, 10);
                myPet.Happiness = Math.Max(myPet.Happiness - 1, 0);
                 //Checking Pet Status
                 if (myPet.Hunger >= 10)
                {
                    Console.WriteLine($"{myPet.Name} is starving!");
                    myPet.Health = Math.Max(myPet.Health - 2, 0);
                }
                if (myPet.Happiness <= 0)
                {
                    Console.WriteLine($"{myPet.Name} is very unhappy!");
                    myPet.Health = Math.Max(myPet.Health - 2, 0);
                }
            }

            Console.WriteLine("Thank you for playing!");
        }
    }
}
