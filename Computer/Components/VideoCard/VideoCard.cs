using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Components.VideoCard
{
    public class VideoCard : IComponent
    {
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public string VideoChipset { get; private set; }
        public int GPUFrequency { get; private set; }
        public int VideoMemorySizeGB { get; private set; }
        public string VideoMemoryType { get; private set; }
        public int VideoMemoryFrequency { get; private set; }
        public int RecomendedPower {  get; private set; }

        public VideoCard(string manufacturer,
                         string model,
                         string videoChipset,
                         int gpuFrequency,
                         int videoMemorySizeGB,
                         string videoMemoryType,
                         int videoMemoryFrequency,
                         int recomendedPower)
        {
            Validate(manufacturer, model, videoChipset, gpuFrequency, videoMemorySizeGB, videoMemoryType, videoMemoryFrequency, recomendedPower);

            Manufacturer = manufacturer;
            Model = model;
            VideoChipset = videoChipset;
            GPUFrequency = gpuFrequency;
            VideoMemorySizeGB = videoMemorySizeGB;
            VideoMemoryType = videoMemoryType;
            VideoMemoryFrequency = videoMemoryFrequency;
            RecomendedPower = recomendedPower;
        }

        private static void Validate(string manufacturer, string model, string videoChipset, int gpuFrequency, int videoMemorySizeGB, string videoMemoryType, int videoMemoryFrequency, int recomendedPower)
        {
            if (String.IsNullOrWhiteSpace(manufacturer))
                throw new ArgumentNullException(nameof(manufacturer));
            if (String.IsNullOrWhiteSpace(model))
                throw new ArgumentNullException(nameof(model));
            if (String.IsNullOrWhiteSpace(videoChipset))
                throw new ArgumentNullException(nameof(videoChipset));
            if (gpuFrequency <= 0)
                throw new ArgumentOutOfRangeException($"{nameof(gpuFrequency)} less or equal 0, current value: {gpuFrequency}.");
            if (videoMemorySizeGB <= 0)
                throw new ArgumentOutOfRangeException($"{nameof(videoMemorySizeGB)} less or equal 0, current value {videoMemorySizeGB}");
            if (String.IsNullOrWhiteSpace(videoMemoryType))
                throw new ArgumentNullException(nameof(videoMemoryType));
            if (videoMemoryFrequency <= 0)
                throw new ArgumentOutOfRangeException(nameof(videoMemoryFrequency));
            if (recomendedPower <= 0)
                throw new ArgumentOutOfRangeException(nameof(recomendedPower));
        }

        public void GetConfiguration()
        {
            Console.WriteLine($"Video Card info:\n" +
                              $"Manufacturer: {Manufacturer}\n" +
                              $"Model: {Model}\n" +
                              $"Video chipset: {VideoChipset}\n" +
                              $"GPU frequency: {GPUFrequency}\n" +
                              $"Video memory size: {VideoMemorySizeGB} GB\n" +
                              $"Video memory type: {VideoMemoryType}\n" +
                              $"Video memory frequency: {VideoMemoryFrequency}\n" +
                              $"Recomended power: {RecomendedPower}\n");
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            return (Manufacturer == ((VideoCard)obj).Manufacturer
                    && Model == ((VideoCard)obj).Model
                    && VideoChipset == ((VideoCard)obj).VideoChipset
                    && GPUFrequency == ((VideoCard)obj).GPUFrequency
                    && VideoMemorySizeGB == ((VideoCard)obj).VideoMemorySizeGB
                    && VideoMemoryType == ((VideoCard)obj).VideoMemoryType
                    && VideoMemoryFrequency == ((VideoCard)obj).VideoMemoryFrequency
                    && RecomendedPower == ((VideoCard)obj).RecomendedPower);
        }
    }
}
