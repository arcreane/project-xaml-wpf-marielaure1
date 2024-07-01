using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Elements.Buildings.ResidentialBuilding
{
    public abstract class ResidentialBuilding : Building
    {
        public ResidentialBuilding()
        {
        }

        public int NumberOfOccupants { get; set; }

        public int Level { get; set; }

        public void GetNumberOfOccupants()
        {
            // TODO implement here
        }

        public void SetNumberOfOccupants()
        {
            // TODO implement here
        }
    }
}
