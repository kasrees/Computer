using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Components.VideoCard
{
    public class PalitVideoCard : VideoCard
    {
        public PalitVideoCard() 
            : base("Palit", "PA-RTX3060 DUAL 12G", "NVIDIA GeForce RTX 3060", 1320, 12, "GDDR6", 15000, 550)
        {
        }
    }
}
