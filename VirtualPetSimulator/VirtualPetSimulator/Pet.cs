using System;

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
            if (Happiness < 2)
            {
                Console.WriteLine($"{Name} is too unhappy to eat. Play with {Name} first. Health: {Health}");
                return;
            }
            Hunger = Math.Max(Hunger - 2, 0);
            Health = Math.Min(Health + 1, 10);
            Console.WriteLine($"{Name} has had its meal. Hunger decreased and Health slightly increased.\nHunger:{Hunger}\nHealth:{Health}");
        }
        public void Play()
        {
            if (Hunger > 7)
            {
                Console.WriteLine($"{Name} is too hungry to play.");
                return;
            }
            Happiness = Math.Min(Happiness + 2, 10);
            Hunger = Math.Min(Hunger + 1, 10);
            Console.WriteLine($"{Name} is playing and is happier now, but a bit hungrier.\nHappiness:{Happiness}\nHunger:{Hunger}");
        }

        public void Rest()
        {
            if (Happiness < 2)
            {
                Console.WriteLine($"{Name} is too unhappy to rest. Play with {Name} first. Health: {Health}");
                return;
            }
            Health = Math.Min(Health + 2, 10);
            Happiness = Math.Max(Happiness - 1, 0);
            Console.WriteLine($"{Name} is resting. Health has improved, but happiness has slightly decreased.\nHealth:{Health}\nHappiness:{Happiness}");
        }
        public void CheckStatus()
        {
            Console.WriteLine($"Status of {Name}: Hunger: {Hunger}, Happiness: {Happiness}, Health: {Health}");
            if (Health < 4)
            {
                Console.WriteLine($"{Name} is not feeling well. Please take better care of {Name}.");
            }
            else if (Hunger > 8)
            {
                Console.WriteLine($"{Name} is very hungry. Please feed {Name} soon.");
            }
            else if (Happiness < 2)
            {
                Console.WriteLine($"{Name} is very unhappy. Spend some time playing with {Name}.");
            }
        }

        public void TimePasses()
        {
            Hunger = Math.Min(Hunger + 1, 10);
            Happiness = Math.Max(Happiness - 1, 0);

            if (Hunger > 8 )
            {
                Health = Math.Max(Health - 1, 0);
                Console.WriteLine($"{Name}'s health is deteriorating due to neglect. Health: {Health}");
            }
            else if (Happiness < 2)
            {
                Health = Math.Max(Health - 1, 0);
                Console.WriteLine($"{Name}'s health is deteriorating due to unhappiness. Health: {Health}");
            }
        }
    }
}


