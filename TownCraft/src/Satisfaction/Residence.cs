using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Satisfaction
{
    public class Residence : Satisfaction
    {

        public Residence()
        {
            NumberOfOccupants = 0;
            ResidenceBuildings = 0;
        }

        public int NumberOfOccupants { get; set; }

        public int ResidenceBuildings { get; set; }

        public double CalculateResidenceSatisfaction()
        {
            SatisfactionRate = NumberOfOccupants * ResidenceBuildings * 10;
            return SatisfactionRate;
        }

        public int GetNumberOfOccupants()
        {
            return NumberOfOccupants;
        }

        public void SetNumberOfOccupants(int numberOfOccupants)
        {
            NumberOfOccupants += numberOfOccupants;
        }

        public int GetResidenceBuildings()
        {
            return ResidenceBuildings;
        }

        public void SetResidenceBuildings()
        {
            ResidenceBuildings++;
        }
    }
}
