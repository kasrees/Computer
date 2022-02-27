using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Components.Processors
{
    public class IntelProcessor : Processor
    {
        public IntelProcessor() 
            : base("Intel", "Core i5 10400F", 6, 2900, "LGA 1200")
        {
        }
    }
}
