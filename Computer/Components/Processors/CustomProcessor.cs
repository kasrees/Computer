using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Components.Processors
{
    public class CustomProcessor : Processor
    {
        public CustomProcessor(string manufacturer, string model, int coreAmount, int coreFrequency, string socket) 
            : base(manufacturer, model, coreAmount, coreFrequency, socket)
        {
        }
    }
}
