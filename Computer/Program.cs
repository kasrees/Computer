using Computer.Components.MotherBoards;
using Computer.Components.PowerUnit;
using Computer.Components.Processors;
using Computer.Components.RandomAccessMemory;
using Computer.Components.VideoCard;

namespace Computer
{
    class Program
    {
        public static void Main(string[] args)
        {
            MotherBoard motherBoard = new MsiMotherBoard();
            Processor processor = new IntelProcessor();
            VideoCard videoCard = new PalitVideoCard();
            List<RandomAccessMemory> ramList = new List<RandomAccessMemory>()
            {
                new LenovoRandomAccessMemory(),
                new LenovoRandomAccessMemory()
            };
            PowerUnit powerUnit = new AeorocoolPowerUnit();
            
            Computer computer = new Computer(motherBoard, processor, videoCard, ramList, powerUnit, "mATX");
            computer.GetConfiguration();
        }
    }
}
