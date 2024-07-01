
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Satisfaction
{
    public class Satisfaction
    {

        public Satisfaction()
        {
        }

        public double SatisfactionRate { get; set; }

        public double GetSatisfaction()
        {
            return SatisfactionRate;
        }

        public void AddSatisfaction(double satisfaction)
        {
            SatisfactionRate += satisfaction;
        }

        public void RemoveSatisfaction(double satisfaction)
        {
            SatisfactionRate -= satisfaction;
        }
    }
}