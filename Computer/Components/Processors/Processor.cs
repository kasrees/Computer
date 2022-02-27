namespace Computer.Components.Processors
{
    public abstract class Processor : IComponent
    {
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public int CoreAmount {  get; private set; }
        public int CoreFrequency { get; private set; }
        public string Socket { get; private set; }

        public Processor(string manufacturer, string model, int coreAmount, int coreFrequency, string socket)
        {
            Validate(manufacturer, model, coreAmount, coreFrequency, socket);

            Manufacturer = manufacturer;
            Model = model;
            CoreAmount = coreAmount;
            CoreFrequency = coreFrequency;
            Socket = socket;
        }

        private void Validate(string manufacturer, string model, int coreAmount, int coreFrequency, string socket)
        {
            if (String.IsNullOrWhiteSpace(manufacturer))
                throw new ArgumentNullException(nameof(manufacturer));
            if (String.IsNullOrWhiteSpace(model))
                throw new ArgumentNullException(nameof(model));
            if (coreAmount <= 0)
                throw new ArgumentOutOfRangeException($"{nameof(coreAmount)} can't be less or equal 0, current value: {coreAmount}");
            if (coreFrequency <= 0)
                throw new ArgumentOutOfRangeException($"{nameof(coreFrequency)} can't be less or equal 0, current value: {coreFrequency}");
            if (String.IsNullOrWhiteSpace(socket))
                throw new ArgumentNullException(nameof(socket));
        }

        public void GetConfiguration()
        {
            Console.WriteLine($"Processor info:\n" +
                              $"Manufacturer: {Manufacturer}\n" +
                              $"Model: {Model}\n" +
                              $"Core amount: {CoreAmount}\n" +
                              $"Core frequency: {CoreFrequency}\n" +
                              $"Socket: {Socket}");
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            return (Manufacturer == ((Processor)obj).Manufacturer
                    && Model == ((Processor)obj).Model
                    && CoreAmount == ((Processor)obj).CoreAmount
                    && CoreFrequency == ((Processor)obj).CoreFrequency
                    && Socket == ((Processor)obj).Socket);
        }
    }
}
