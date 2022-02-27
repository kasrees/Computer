using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Components.MotherBoards
{
    public class CustomMotherBoard : MotherBoard
    {
        public CustomMotherBoard(string manufacturer,
                                 string model,
                                 string formFactor,
                                 string socket,
                                 string chipset,
                                 int maxMemoryFrequency,
                                 int memorySlots,
                                 int maxMemorySizeGB,
                                 bool isAllowDualMemoryChannel) 
            : base(manufacturer,
                   model,
                   formFactor,
                   socket,
                   chipset,
                   maxMemoryFrequency,
                   memorySlots,
                   maxMemorySizeGB,
                   isAllowDualMemoryChannel)
        {
        }
    }
}
