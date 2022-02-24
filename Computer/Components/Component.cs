namespace Computer.Components
{
    public abstract class Component : IComponent
    {
        public string Name { get; private set; }
        public string Manufacturer { get; private set; }

        public Component(string name, string manufacturer)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrWhiteSpace(manufacturer))
                throw new ArgumentNullException(nameof(manufacturer));

            Name = name;
            Manufacturer = manufacturer;
        }

        public virtual void GetConfiguration()
        {
            Console.WriteLine($"Name: {Name}\nManufacturer: {Manufacturer}");
        }
    }
}
