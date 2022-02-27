using Computer.Components;
using Computer.Components.MotherBoards;
using Computer.Components.PowerUnit;
using Computer.Components.Processors;
using Computer.Components.RandomAccessMemory;
using Computer.Components.VideoCard;

namespace Computer
{
    public class Computer
    {
        public string FormFactor { get; private set; }
        public MotherBoard MotherBoard { get; private set; }
        public Processor Processor { get; private set; }
        public VideoCard VideoCard { get; private set; }
        public List<RandomAccessMemory> RandomAccessMemory { get; private set; } = new List<RandomAccessMemory>();
        public PowerUnit PowerUnit { get; private set; }

        private List<IComponent> _components = new List<IComponent>();

        public Computer(MotherBoard motherBoard, Processor processor, VideoCard videoCard, List<RandomAccessMemory> randomAccessMemory, PowerUnit powerUnit, string formFactor)
        {
            Validate(motherBoard, processor, videoCard, randomAccessMemory, powerUnit, formFactor);

            MotherBoard = motherBoard;
            Processor = processor;
            VideoCard = videoCard;
            RandomAccessMemory.AddRange(randomAccessMemory);
            PowerUnit = powerUnit;
            FormFactor = formFactor;

            ValidateCompability();
            SetComponentsToList();
        }

        private void Validate(MotherBoard motherBoard, Processor processor, VideoCard videoCard, List<RandomAccessMemory> randomAccessMemory, PowerUnit powerUnit, string formFactor)
        {
            if (motherBoard == null)
                throw new ArgumentNullException(nameof(motherBoard));
            if (processor == null)
                throw new ArgumentNullException(nameof(processor));
            if (videoCard == null)
                throw new ArgumentNullException(nameof(videoCard));
            if (randomAccessMemory == null)
                throw new ArgumentNullException(nameof(randomAccessMemory));
            if (randomAccessMemory.Count == 0)
                throw new ArgumentException($"{nameof(randomAccessMemory)} list can't be empty");
            if (powerUnit == null)
                throw new ArgumentNullException(nameof(powerUnit));
            if (String.IsNullOrWhiteSpace(formFactor))
                throw new ArgumentNullException(nameof(formFactor));
        }

        private void ValidateCompability()
        {
            CheckMotherBoardCompability();
            CheckProcessorCompability();
            CheckVideoCardCompability();
            CheckRandomAccessMemory();
        }

        private void CheckMotherBoardCompability()
        {
            if (FormFactor != MotherBoard.FormFactor)
                throw new ArgumentException($"Motherboard form factor is not compatible. Motherboard from factor: {MotherBoard.FormFactor}, Computer form factor: {FormFactor}");
        }

        private void CheckProcessorCompability()
        {
            if (MotherBoard.Socket != Processor.Socket)
                throw new ArgumentException($"Processor socket is different from motherboard, processor soket: {Processor.Socket}, motherboard socket: {MotherBoard.Socket}");
        }

        private void CheckVideoCardCompability()
        {
            if (PowerUnit.Power < VideoCard.RecomendedPower)
                throw new ArgumentException($"Not enough power for video card, current power: {PowerUnit.Power}, video card power: {VideoCard.RecomendedPower}");
        }

        private void CheckRandomAccessMemory()
        {
            if (RandomAccessMemory.Count > MotherBoard.MemorySlots)
                throw new ArgumentException($"RAM count more then slots in motherboard, curren value {RandomAccessMemory.Count}");
            if (RandomAccessMemory.Sum(m => m.MemorySizeGB) > MotherBoard.MaxMemorySizeGB)
                throw new ArgumentException($"RAM size more then allow motherboard, current value {RandomAccessMemory.Sum(m => m.MemorySizeGB)}");
            if (RandomAccessMemory.Max(m => m.MemoryFrequency) > MotherBoard.MaxMemoryFrequency)
                throw new ArgumentException($"RAM frequency more then allow motherboard, current value {RandomAccessMemory.Max(m => m.MemoryFrequency)}");
        }

        private void SetComponentsToList()
        {
            _components.Add(MotherBoard);
            _components.Add(Processor);
            _components.Add(VideoCard);
            _components.Add(PowerUnit);
            _components.AddRange(RandomAccessMemory);
        }

        public void GetConfiguration()
        {
            MotherBoard.GetConfiguration();
            Processor.GetConfiguration();
            VideoCard.GetConfiguration();
            RandomAccessMemory.ForEach(m => m.GetConfiguration());
            PowerUnit.GetConfiguration();
        }

        public List<IComponent> GetComponents()
        {
            return _components;
        }


    }
}
