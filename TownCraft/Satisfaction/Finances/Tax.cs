using System;

namespace TownCraft.Satisfaction.Finances
{
    public class Tax
    {
        public Tax()
        {
        }

        public decimal Amount { get; set; }

        public decimal Percent { get; set; }

        public decimal GetAmount()
        {
            return Amount;
        }

        public void SetAmount(decimal amount)
        {
            Amount = amount;
        }

        public decimal GetPercent()
        {
            return Percent;
        }

        public void SetPercent(decimal percent)
        {
            Percent = percent;
        }
    }
}
