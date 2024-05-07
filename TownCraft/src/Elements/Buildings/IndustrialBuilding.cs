using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Elements.Buildings
{
    public class IndustrialBuilding : Building
    {
        public IndustrialBuilding()
        {
        }

        public string Category { get; } = "industrial";

        public override void SetPollutionGenerate()
        {
            throw new NotImplementedException();
        }
    }
}
