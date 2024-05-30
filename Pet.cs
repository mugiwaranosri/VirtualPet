namespace VirtualPet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Health { get; set; }

        public Pet(string name, string type)
        {
            Name = name;
            Type = type;
            Hunger = 5;
            Happiness = 5;
            Health = 5;
        }
        public void Feed()
        {
            Hunger = Math.Max(Hunger - 2, 0);
            Health = Math.Min(Health + 1, 10);
            Console.WriteLine($"{Name} has had its meal. Hunger decreased and Health slightly increased.");
        }
    }
}


