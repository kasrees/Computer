using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Components.RandomAccessMemory
{
    public class CustomRandomAccessMemory : RandomAccessMemory
    {
        public CustomRandomAccessMemory(string manufacturer, string model, string memoryType, int memoryFrequency, int memorySizeMB) 
            : base(manufacturer, model, memoryType, memoryFrequency, memorySizeMB)
        {
        }
    }
}
