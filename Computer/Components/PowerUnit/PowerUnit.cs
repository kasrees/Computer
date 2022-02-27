namespace Computer.Components.PowerUnit
{
    public abstract class PowerUnit : IComponent
    {
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public int Power { get; private set; }

        public PowerUnit(string manufacturer, string model, int power)
        {
            Validate(manufacturer, model, power);

            Manufacturer = manufacturer;
            Model = model;
            Power = power;
        }

        private void Validate(string manufacturer, string model, int power)
        {
            if (String.IsNullOrWhiteSpace(manufacturer))
                throw new ArgumentNullException(nameof(manufacturer));
            if (String.IsNullOrWhiteSpace(model))
                throw new ArgumentNullException(nameof(model));
            if (power <= 0)
                throw new ArgumentOutOfRangeException($"{nameof(power)} can't be less or equal 0, current value: {power}");
        }

        public void GetConfiguration()
        {
            Console.WriteLine($"Power unit info:\n" +
                              $"Manufacturer: {Manufacturer}\n" +
                              $"Model: {Model}\n" +
                              $"Power: {Power}\n");
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            return (Manufacturer == ((PowerUnit)obj).Manufacturer
                    && Model == ((PowerUnit)obj).Model
                    && Power == ((PowerUnit)obj).Power);
        }
    }
}
