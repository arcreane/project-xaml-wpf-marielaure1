using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Elements.Buildings.SecurityBuilding
{
    public class SecurityBuilding : Building
    {
        public SecurityBuilding()
        {
        }

        public int NumberOfAgents { get; set; }

        public string Category { get; } = "security";

        public void GetNumberOfAgents()
        {
            // TODO implement here
        }

        public void SetNumberOfAgents()
        {
            // TODO implement here
        }

        public override void SetPollutionGenerate()
        {
            throw new NotImplementedException();
        }
    }
}
