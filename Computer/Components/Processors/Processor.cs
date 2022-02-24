namespace Computer.Components.Processors
{
    public abstract class Processor : Component
    {
        public int CoreAmount { get; private set; }
        public double CoreFrequency { get; private set; }
        public Processor(string name, string manufacturer, double coreFrecuency, int coreAmount) : base(name, manufacturer)
        {
            if (coreAmount < 1)
                throw new ArgumentOutOfRangeException(nameof(coreAmount));
            if (coreFrecuency < 0)
                throw new ArgumentOutOfRangeException(nameof(coreFrecuency));

            CoreAmount = coreAmount;
            CoreFrequency = coreFrecuency;
        }

        public override void GetConfiguration()
        {
            base.GetConfiguration();
            Console.WriteLine($"Number of cores: {CoreAmount}\nCore frequency: {CoreFrequency}");
        }
    }
}
