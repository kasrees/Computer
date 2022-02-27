using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Components.VideoCard
{
    public class CustomVideoCard : VideoCard
    {
        public CustomVideoCard(string manufacturer,
                               string model,
                               string videoChipset,
                               int gpuFrequency,
                               int videoMemorySizeGB,
                               string videoMemoryType,
                               int videoMemoryFrequency,
                               int recomendedPower) 
            : base(manufacturer,
                   model,
                   videoChipset,
                   gpuFrequency,
                   videoMemorySizeGB,
                   videoMemoryType,
                   videoMemoryFrequency,
                   recomendedPower)
        {
        }
    }
}
