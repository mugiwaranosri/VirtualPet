namespace VirtualPet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Pet(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}

