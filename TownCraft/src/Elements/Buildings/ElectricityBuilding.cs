using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Elements.Buildings
{
    public class ElectricityBuilding : Building
    {
        public ElectricityBuilding()
        {
        }

        public string Category { get; } = "electricity";

        public int ElectricityProduction { get; set; }

        public void GetElectricityProduction()
        {
            // TODO implement here
        }

        public void SetElectricityProduction()
        {
            // TODO implement here
        }

        public override void SetPollutionGenerate()
        {
            throw new NotImplementedException();
        }
    }
}
