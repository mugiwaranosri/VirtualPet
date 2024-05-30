using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose a pet type (e.g., cat, dog, rabbit): ");
            string petType = Console.ReadLine();
            Console.Write("Give your pet a name: ");
            string petName = Console.ReadLine();
            Pet myPet = new Pet(petName, petType);

            Console.WriteLine($"Welcome, {myPet.Name} the {myPet.Type}!");
        }
    }
}
