using System;

namespace TownCraft.Satisfaction.Finances
{
    public class Finance : Satisfaction
    {
        public Finance()
        {
        }

        public decimal CityFlouz { get; set; }

        public decimal GetCityFlouz()
        {
            return CityFlouz;
        }

        public void SetCityFlouz(decimal cityFlouz)
        {
            CityFlouz = cityFlouz;
        }

        public void AddToCityFlouz(decimal amount)
        {
            CityFlouz += amount;
        }

        public bool RemoveFromCityFlouz(decimal amount)
        {
            if (CityFlouz >= amount)
            {
                CityFlouz -= amount;

                return true;
            }
            
            return false;
            
        }
    }
}
