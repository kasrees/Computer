using Computer.Components.Processors;

namespace Computer.Components.MotherBoards
{
    public abstract class MotherBoard : Component
    {
        public Processor Processor { get; private set; }
        public MotherBoard(string name, string manufacturer, Processor processor) : base(name, manufacturer)
        {
            Processor = processor ?? throw new ArgumentNullException(nameof(processor));
        }

        public override void GetConfiguration()
        {
            base.GetConfiguration();
            Console.WriteLine("\n");
            Processor.GetConfiguration();
        }
    }
}
