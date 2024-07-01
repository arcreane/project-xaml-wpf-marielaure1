
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Elements.Buildings.ResidentialBuilding
{
    public class ApartmentBlock : ResidentialBuilding
    {

        public int NumberOfOccupants { get; private set; }
        public int Tax { get; private set; }
        public decimal ConstructionCost { get; private set; }
        public ApartmentBlock()
        {
            Type = "apartment-block";
            NumberOfOccupants = 30;
            Tax = 2000;
            ConstructionCost = 300000;
        }

        public override void SetPollutionGenerate()
        {
            throw new NotImplementedException();
        }

        public string GetImageLevel()
        {
            return "pack://application:,,,/src/Ui/Real Estate.png";
        }
    }
}