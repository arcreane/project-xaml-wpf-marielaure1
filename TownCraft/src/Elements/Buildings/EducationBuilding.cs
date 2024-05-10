using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Elements.Buildings
{
    public class EducationBuilding : Building
    {
        public EducationBuilding()
        {
        }

        public string Category { get; } = "education";

        public int NumberOfPlaces { get; set; }

        public void GetNumberOfPlaces()
        {
            // TODO implement here
        }

        public void SetNumberOfPlaces()
        {
            // TODO implement here
        }

        public override void SetPollutionGenerate()
        {
            throw new NotImplementedException();
        }
    }
}
