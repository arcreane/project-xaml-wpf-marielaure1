using System;

namespace TownCraft.Satisfaction.Finances
{
    public class Maintenance
    {
        public Maintenance()
        {
        }

        public decimal Amount { get; set; }

        public decimal GetAmount()
        {
            return Amount;
        }

        public void SetAmount(decimal amount)
        {
            Amount = amount;
        }
    }
}
