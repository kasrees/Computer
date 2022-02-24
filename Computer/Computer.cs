using Computer.Components;
using Computer.Components.MotherBoards;
using Computer.Components.Processors;
using System;
using System.Collections.Generic;
namespace Computer
{
    public class Computer
    {
        public MotherBoard MotherBoard { get; private set; }

        public Computer(MotherBoard motherBoard)
        {
            MotherBoard = motherBoard;
        }

        public void GetConfiguration()
        {
            MotherBoard.GetConfiguration();
        }

    }
}
