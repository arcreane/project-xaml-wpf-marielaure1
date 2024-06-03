
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Elements.Buildings.SecurityBuilding
{
    public class PoliceStation : SecurityBuilding
    {

        public PoliceStation()
        {
        }
        
        public string GetImageLevel()
        {
            return "pack://application:,,,/src/Ui/Police Badge.png";
        }

    }
}