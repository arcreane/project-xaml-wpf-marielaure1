
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum Level
{
}


namespace TownCraft.Elements.Buildings.ResidentialBuilding
{
    public class House : ResidentialBuilding
    {
        public int NumberOfOccupants { get; private set; }
        public int Tax { get; private set; }
        public decimal ConstructionCost { get; private set; }
        public House()
        {
            Type = "House";
            NumberOfOccupants = 5;
            Tax = 1000;
            ConstructionCost = 200000;
        }

        public override void SetPollutionGenerate()
        {
            throw new NotImplementedException();
        }

        public string GetImageLevel()
        {
            return "pack://application:,,,/src/Ui/Exterior.png";
        }
    }
}


