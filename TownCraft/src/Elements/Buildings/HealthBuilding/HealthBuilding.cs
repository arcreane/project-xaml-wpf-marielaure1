using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Elements.Buildings.HealthBuilding
{
    public abstract class HealthBuilding : Building
    {
        public HealthBuilding()
        {
        }

        public int NumberOfBeds { get; set; }

        public string Category { get; } = "health";

        public void GetNumberOfBeds()
        {
            // TODO implement here
        }

        public void SetNumberOfBeds()
        {
            // TODO implement here
        }
    }
}
