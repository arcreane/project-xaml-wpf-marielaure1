using System;

public enum SatisfactionRateName
{
    SuperCranky = 1,
    KindaGrumpy = 2,
    Meh = 3,
    PrettyHappy = 4,
    OverTheMoon = 5
}

namespace TownCraft.Core
{
    public class Happiness
    {
        public double SatisfactionRate { get; set; }
        public string SatisfactionName { get; set; }

        public void GetSatisfactionRate()
        {
            Console.WriteLine($"Satisfaction Rate: {SatisfactionRate}");
        }

        public void SetSatisfactionRate(double rate)
        {
            SatisfactionRate = rate;
            SatisfactionName = GetDescription((SatisfactionRateName)rate);
        }

        public void GetSatisfactionName()
        {
            Console.WriteLine($"Satisfaction Name: {SatisfactionName}");
        }

        public void SetSatisfactionName(SatisfactionRateName rateName)
        {
            SatisfactionRate = (double)rateName;
            SatisfactionName = GetDescription(rateName);
        }

        public static string GetDescription(SatisfactionRateName rateName)
        {
            switch (rateName)
            {
                case SatisfactionRateName.SuperCranky:
                    return "Super grincheux";
                case SatisfactionRateName.KindaGrumpy:
                    return "Plutôt grognon";
                case SatisfactionRateName.Meh:
                    return "Bof";
                case SatisfactionRateName.PrettyHappy:
                    return "Assez heureux";
                case SatisfactionRateName.OverTheMoon:
                    return "Aux anges";
                default:
                    return "Inconnu";
            }
        }
    }
}
