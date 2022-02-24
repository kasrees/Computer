using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Components.Processors
{
    public class IntelProcessor : Processor
    {
        public int Series { get; private set; }
        public string Number { get; private set; }
        public IntelProcessor(string name, string manufacturer, double coreFrecuency, int coreAmount, int series, string number) : base(name, manufacturer, coreFrecuency, coreAmount)
        {
            if (!(series == 3 || series == 5 || series == 7))
                throw new ArgumentException("Intel process can have only 3, 5, 7 series.");
            if (String.IsNullOrWhiteSpace(number))
                throw new ArgumentNullException(nameof(number));
            Series = series;
            Number = number;
        }

        public override void GetConfiguration()
        {
            base.GetConfiguration();
            Console.WriteLine($"Series: {Series}\nNumber: {Number}");
        }
    }
}
