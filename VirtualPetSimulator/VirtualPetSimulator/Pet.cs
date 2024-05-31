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
        public void Play()
        {
            Happiness = Math.Min(Happiness + 2, 10);
            Hunger = Math.Min(Hunger + 1, 10);
            Console.WriteLine($"{Name} has played and is happier now, but a bit hungrier.");
        }

        public void Rest()
        {
            Health = Math.Min(Health + 2, 10);
            Happiness = Math.Max(Happiness - 1, 0);
            Console.WriteLine($"{Name} is rested. Health has improved, but happiness has slightly decreased.");
        }
        public void DisplayStats()
        {
            Console.WriteLine($"\nPet Stats: \nName: {Name} \nType: {Type} \nHunger: {Hunger} \nHappiness: {Happiness} \nHealth: {Health}");
        }
    }
}


