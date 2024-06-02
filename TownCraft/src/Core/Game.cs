using System;
using TownCraft.Satisfaction.Finances;

namespace TownCraft.Core
{
    public class Game
    {
        public Player Player { get; set; }
        public City City { get; set; }
        public bool IsRunning { get; set; }
        public Happiness Happiness { get; set; }
        public Finance Finance { get; set; }
        public Tax Tax { get; set; }
        public Maintenance Maintenance { get; set; }

        public Game()
        {
            Player = new Player();
            City = new City();
            Happiness = new Happiness();
            Finance = new Finance();
            Tax = new Tax();
            Maintenance = new Maintenance();
        }

        public void CreatePlayer(string name)
        {
            int level = 1;
            int ChallengesCompleted = 1;
            SetPlayer(name, level, ChallengesCompleted);
        }

        public void CreateCity(string name)
        {
            int numberOfCitizen = 0;
            SetCity(name, numberOfCitizen);
            SetDatas(3);
        }

        public void CreateFinance()
        {
            SetTax(0);
            SetMaintenance(0);
            SetCityFlouz(150000);
        }

        public void LoadPlayer(int id)
        {
            string name = "Marie";
            int level = 1;
            int ChallengesCompleted = 1;
            SetPlayer(name, level, ChallengesCompleted);
        }

        public void SetPlayer(string name, int level, int challengesCompleted)
        {
            Player.SetName(name);
            Player.SetLevel(level);
            Player.SetChallengesCompleted(challengesCompleted);
        }

        public void SetCity(string name, int numberOfCitizen)
        {
            City.SetName(name);
            City.SetNumberOfCitizen(numberOfCitizen);
        }

        public void SetTax(decimal taxAmount)
        {
            Tax.SetAmount(taxAmount);
        }

        public void SetMaintenance(decimal maintenanceAmount)
        {
            Maintenance.SetAmount(maintenanceAmount);
        }

        public void SetCityFlouz(decimal cityFlouz)
        {
            Finance.SetCityFlouz(cityFlouz);
        }

        public decimal GetCityFlouz()
        {
            return Finance.GetCityFlouz();
        }

        public string GetPlayer()
        {
            return Player.GetName();
        }

        public string GetCity()
        {
            return City.GetName();
        }

        public void SetDatas(int happiness)
        {
            if (Enum.IsDefined(typeof(SatisfactionRateName), happiness))
            {
                Happiness.SetSatisfactionRate(happiness);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(happiness), "Happiness rate must be between 1 and 5.");
            }
        }

        public string GetSatisfactionDescription()
        {
            return Happiness.GetDescription((SatisfactionRateName)Happiness.SatisfactionRate);
        }
    }
}
