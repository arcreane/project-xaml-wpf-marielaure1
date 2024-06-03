using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Elements.Buildings
{
    public class EducationBuilding : Building
    {

        public int NumberOfOccupants { get; private set; }
        public int Tax { get; private set; }
        public decimal ConstructionCost { get; private set; }
        public EducationBuilding()
        {
            Type = "Education";
            NumberOfOccupants = 200;
            Tax = 20000;
            ConstructionCost = 500000;
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

        public string GetImageLevel()
        {
            return "pack://application:,,,/src/Ui/noto_post-office.png";
        }
    }
}
