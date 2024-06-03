using TownCraft.Elements.Buildings.Infrastructure;
using TownCraft.Elements.Buildings;

namespace TownCraft.Core
{
    public class Cell
    {
        public Cell()
        {
        }

        public int X { get; set; }
        public int Y { get; set; }
        public string Type { get; set; }
        public bool Available { get; set; } = true;
        public Infrastructure Infrastructure { get; set; }
        public Building Building { get; set; }

        public string GetType()
        {
            // TODO implement here
            return "";
        }

        public bool IsAvailable()
        {
            return Available;
        }

        public void SetInfrastructure(Infrastructure infrastructure)
        {
            // TODO implement here
        }

        public void SetBuilding(Building building)
        {
            Building = building;
            Available = false; // La cellule n'est plus disponible
        }

        public Infrastructure GetInfrastructure()
        {
            // TODO implement here
            return null;
        }

        public Building GetBuilding()
        {
            return Building;
        }
    }
}
