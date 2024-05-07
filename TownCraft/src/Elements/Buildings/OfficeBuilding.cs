using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Elements.Buildings
{
    public class OfficeBuilding : Building
    {
        public OfficeBuilding()
        {
        }

        public string Category { get; } = "office";

        public override void SetPollutionGenerate()
        {
            throw new NotImplementedException();
        }
    }
}
