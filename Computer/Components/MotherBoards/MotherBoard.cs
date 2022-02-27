using Computer.Components.Processors;

namespace Computer.Components.MotherBoards
{
    public abstract class MotherBoard : IComponent
    {
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public string FormFactor { get; private set; }
        public string Socket { get; private set; }
        public string Chipset { get; private set; }
        public int MaxMemoryFrequency { get; private set; }
        public int MemorySlots { get; private set; }
        public int MaxMemorySizeGB { get; private set; }
        public bool IsAllowDualMemoryChannel { get; private set; }

        public MotherBoard(string manufacturer,
                           string model,
                           string formFactor,
                           string socket,
                           string chipset,
                           int maxMemoryFrequency,
                           int memorySlots,
                           int maxMemorySizeGB,
                           bool isAllowDualMemoryChannel)
        {
            Validate(manufacturer, model, formFactor, socket, chipset, maxMemoryFrequency, memorySlots, maxMemorySizeGB);

            Manufacturer = manufacturer;
            Model = model;
            FormFactor = formFactor;
            Socket = socket;
            Chipset = chipset;
            MaxMemoryFrequency = maxMemoryFrequency;
            MemorySlots = memorySlots;
            MaxMemorySizeGB = maxMemorySizeGB;
            IsAllowDualMemoryChannel = isAllowDualMemoryChannel;
            
        }

        private void Validate(string manufacturer, string model, string formFactor, string socket, string chipset, int maxMemoryFrequency, int memorySlots, int maxMemorySizeGB)
        {
            if (String.IsNullOrWhiteSpace(manufacturer))
                throw new ArgumentNullException(nameof(manufacturer));
            if (String.IsNullOrWhiteSpace(model))
                throw new ArgumentNullException(nameof(model));
            if (String.IsNullOrWhiteSpace(formFactor))
                throw new ArgumentNullException(nameof(formFactor));
            if (String.IsNullOrWhiteSpace(socket))
                throw new ArgumentNullException(nameof(socket));
            if (String.IsNullOrWhiteSpace(chipset))
                throw new ArgumentNullException(nameof(chipset));
            if (maxMemoryFrequency <= 0)
                throw new ArgumentOutOfRangeException($"{nameof(maxMemoryFrequency)} can't be less or equal 0, current value {maxMemoryFrequency}");
            if (memorySlots <= 0)
                throw new ArgumentOutOfRangeException($"{nameof(memorySlots)} can't be less or equal 0, current value {memorySlots}");
            if (maxMemorySizeGB <= 0)
                throw new ArgumentOutOfRangeException($"{nameof(maxMemorySizeGB)} can't be less or equal 0, current value {maxMemorySizeGB}");
            
        }

        public void GetConfiguration()
        {
            Console.WriteLine($"Motherboard info:\n" +
                              $"Manufacturer: {Manufacturer}\n" +
                              $"Model: {Model}\n" +
                              $"FormFactor: {FormFactor}\n" +
                              $"Socket: {Socket}\n" +
                              $"Chipset: {Chipset}\n" +
                              $"Max memory frequency: {MaxMemoryFrequency}\n" +
                              $"Memory slots: {MemorySlots}\n" +
                              $"Max memory size: {MaxMemorySizeGB} GB\n" +
                              $"Dual memory channel: {(IsAllowDualMemoryChannel ? "Yes" : "No")}\n");
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            return (Manufacturer == ((MotherBoard)obj).Manufacturer
                    && Model == ((MotherBoard)obj).Model
                    && FormFactor == ((MotherBoard)obj).FormFactor
                    && Socket == ((MotherBoard)obj).Socket
                    && Chipset == ((MotherBoard)obj).Chipset
                    && MaxMemoryFrequency == ((MotherBoard)obj).MaxMemoryFrequency
                    && MemorySlots == ((MotherBoard)obj).MemorySlots
                    && MaxMemorySizeGB == ((MotherBoard)obj).MaxMemorySizeGB
                    && IsAllowDualMemoryChannel == ((MotherBoard)obj).IsAllowDualMemoryChannel);
        }
    }
}
