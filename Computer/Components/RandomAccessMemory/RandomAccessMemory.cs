using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Components.RandomAccessMemory
{
    public abstract class RandomAccessMemory : IComponent
    {
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public string MemoryType { get; private set; }
        public int MemoryFrequency { get; private set; }
        public int MemorySizeGB { get; private set; }


        public RandomAccessMemory(string manufacturer, string model, string memoryType, int memoryFrequency, int memorySizeMB)
        {
            Validate(manufacturer, model, memoryType, memoryFrequency, memorySizeMB);

            Manufacturer = manufacturer;
            Model = model;
            MemoryType = memoryType;
            MemoryFrequency = memoryFrequency;
            MemorySizeGB = memorySizeMB;
        }

        private void Validate(string manufacturer, string model, string memoryType, int memoryFrequency, int memorySizeGB)
        {
            if (String.IsNullOrWhiteSpace(manufacturer))
                throw new ArgumentNullException(nameof(manufacturer));
            if (String.IsNullOrWhiteSpace(model))
                throw new ArgumentNullException(nameof(model));
            if (String.IsNullOrWhiteSpace(memoryType))
                throw new ArgumentNullException(nameof(memoryType));
            if (memoryFrequency <= 0)
                throw new ArgumentOutOfRangeException($"{nameof(memoryFrequency)} can't be less or equal 0, current value: {memoryFrequency}");
            if (memorySizeGB <= 0)
                throw new ArgumentOutOfRangeException($"{nameof(memorySizeGB)} can't be less or equal 0, current value: {memorySizeGB}");
        }

        public void GetConfiguration()
        {
            Console.WriteLine($"RAM:\nManufacturer: {Manufacturer}\n" +
                              $"Model: {Model}\n" +
                              $"Memory type: {MemoryType}\n" +
                              $"Memory frequency: {MemoryFrequency}\n" +
                              $"Memory size: {MemorySizeGB} GB\n");
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            return (Manufacturer == ((RandomAccessMemory)obj).Manufacturer
                    && Model == ((RandomAccessMemory)obj).Model
                    && MemoryType == ((RandomAccessMemory)obj).MemoryType
                    && MemoryFrequency == ((RandomAccessMemory)obj).MemoryFrequency
                    && MemorySizeGB == ((RandomAccessMemory)obj).MemorySizeGB);
        }
    }
}
