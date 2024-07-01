
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Elements.Buildings.ResidentialBuilding
{
    public class SocialHousing : ResidentialBuilding
    {

        public SocialHousing()
        {
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