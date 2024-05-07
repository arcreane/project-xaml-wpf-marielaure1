using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Satisfaction
{
    public class Citizen : Satisfaction
    {

        public Citizen()
        {
        }

        public string WorkCategory { get; set; }

        public decimal Income { get; set; }

        public bool IsOffender { get; set; }

        public bool IsUnemployment { get; set; }

        public void GetWorkCategory()
        {
            // TODO implement here
        }

        public void SetWorkCategory()
        {
            // TODO implement here
        }

        public void GetIncome()
        {
            // TODO implement here
        }

        public void SetIncome()
        {
            // TODO implement here
        }
    }
}
