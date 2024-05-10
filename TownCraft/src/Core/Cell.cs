using TownCraft.Elements.Buildings.Infrastructure;
using TownCraft.Elements.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Core
{
    public class Cell : City
    {
        public Cell()
        {
        }

        public int X { get; set; }
        public int Y { get; set; }

        public string Type { get; set; }

        public bool Available { get; set; }

        public Infrastructure Infrastructure { get; set; }

        public Building Building { get; set; }

        public string GetType()
        {
            // TODO implement here
            return "";
        }

        public bool IsAvailable()
        {
            // TODO implement here
            return false;
        }

        public void SetInfrastructure(Infrastructure infrastructure)
        {
            // TODO implement here
        }

        public void SetBuilding(Building building)
        {
            // TODO implement here
        }

        public Infrastructure GetInfrastructure()
        {
            // TODO implement here
            return null;
        }

        public Building GetBuilding()
        {
            // TODO implement here
            return null;
        }
    }
}
