using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Elements.Buildings
{
    public class HobbiesBuilding : Building
    {
        public HobbiesBuilding()
        {
        }

        public string Category { get; } = "hobbies";

        public override void SetPollutionGenerate()
        {
            throw new NotImplementedException();
        }
    }
}
