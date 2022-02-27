using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Components.RandomAccessMemory
{
    public class LenovoRandomAccessMemory : RandomAccessMemory
    {
        public LenovoRandomAccessMemory() 
            : base("Lenovo", "4ZC7A08708", "DDR4", 2933, 16)
        {
        }
    }
}
