using Computer.Components.MotherBoards;
using Computer.Components.Processors;

namespace Computer
{
    class Program
    {
        public static void Main(string[] args)
        {
            Processor processor = new IntelProcessor("Processor", "Intel", 2.4, 2, 3, "100H");
            MotherBoard motherBoard = new MsiMotherBoard("MotherBoard", "MSI", processor, 2);

            Computer computer = new Computer(motherBoard);

            computer.GetConfiguration();
        }
    }
}
