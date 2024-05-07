using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Elements.Buildings.SecurityBuildings
{
    public class SecurityBuildings : Building
    {
        public SecurityBuildings()
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
