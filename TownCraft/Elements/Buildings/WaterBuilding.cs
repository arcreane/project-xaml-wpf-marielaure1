using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Elements.Buildings
{
    public class WaterBuilding : Building
    {
        public WaterBuilding()
        {
        }

        public string Category { get; } = "water";

        public int WaterProduction { get; set; }

        public void GetWaterProduction()
        {
            // TODO implement here
        }

        public override void SetPollutionGenerate()
        {
            throw new NotImplementedException();
        }

        public void SetWaterProduction()
        {
            // TODO implement here
        }

    }
}
