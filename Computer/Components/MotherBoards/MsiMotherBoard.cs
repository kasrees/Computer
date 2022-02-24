using Computer.Components.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Components.MotherBoards
{
    public class MsiMotherBoard : MotherBoard
    {
        public int MemorySlotsCount { get; private set; }

        public MsiMotherBoard(string name, string manufacturer, Processor processor, int memorySlotsCount) : base(name, manufacturer, processor)
        {
            if (memorySlotsCount < 1)
                throw new ArgumentOutOfRangeException(nameof(memorySlotsCount));
            MemorySlotsCount = memorySlotsCount;
        }

        public override void GetConfiguration()
        {
            Console.WriteLine($"Memory slots: {MemorySlotsCount}");
            base.GetConfiguration();
        }
    }
}
