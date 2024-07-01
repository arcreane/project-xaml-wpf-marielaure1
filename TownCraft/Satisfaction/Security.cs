using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Satisfaction
{
    public class Security : Satisfaction
    {

        public Security()
        {
        }

        public int NumberOfAgents { get; set; }

        public int SecurityBuildings { get; set; }

        public void GetNumberOfAgents()
        {
            // TODO implement here
        }

        public void SetNumberOfAgents()
        {
            // TODO implement here
        }

        public void GetSecurityBuildings()
        {
            // TODO implement here
        }

        public void SetSecurityBuildings()
        {
            // TODO implement here
        }

        public string GetImageLevel()
        {
            return "pack://application:,,,/src/Ui/fluent-emoji_police-car-light.png";
        }

    }
}
