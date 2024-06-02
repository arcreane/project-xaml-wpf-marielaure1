using System;
using TownCraft.Satisfaction;

namespace TownCraft.Core
{
    public class City
    {

        public TownCraft.Satisfaction.Citizen Citizen { get; set; }

        public City()
        {
            Citizen = new TownCraft.Satisfaction.Citizen();
        }

        public string Name { get; set; }
        public int NumberOfCitizen { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetNumberOfCitizen(int numberOfCitizen)
        {
            NumberOfCitizen = numberOfCitizen;
        }



        public int GetNumberOfCitizen()
        {
            return NumberOfCitizen;
        }


    }
}
