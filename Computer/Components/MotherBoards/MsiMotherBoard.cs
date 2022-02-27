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
        public MsiMotherBoard() 
            : base("MSI" , "B560M PRO-E", "mATX", "LGA 1200", "Intel B560", 3200, 2, 64, true)
        {
        }
    }
}
