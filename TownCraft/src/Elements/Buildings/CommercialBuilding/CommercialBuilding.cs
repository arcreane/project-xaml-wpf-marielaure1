using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Elements.Buildings.CommercialBuilding
{
    public class CommercialBuilding : Building
    {
        public CommercialBuilding()
        {
        }

        public string Category { get; } = "commercial";

        public override void SetPollutionGenerate()
        {
            throw new NotImplementedException();
        }
    }
}
