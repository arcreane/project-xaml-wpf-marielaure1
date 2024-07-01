
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Elements.Buildings.SecurityBuilding
{
    public class FireStation : SecurityBuilding
    {

        public FireStation()
        {
        }

        public string GetImageLevel()
        {
            return "pack://application:,,,/src/Ui/Fire Engine.png";
        }

    }
}