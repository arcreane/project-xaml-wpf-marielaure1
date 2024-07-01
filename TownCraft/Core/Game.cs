using System;
using TownCraft.Elements.Buildings.ResidentialBuilding;
using TownCraft.Database;
using TownCraft.Satisfaction;
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
        public House House { get; set; }
        public Residence Residence { get; set; }
        public CityRepository CityRepository { get; private set; }

        public Game(GameManager gameManager)
        {
            Player = new Player();
            City = new City(gameManager);
            Happiness = new Happiness();
            Finance = new Finance();
            Tax = new Tax();
            Maintenance = new Maintenance();
            Residence = new Residence();
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
            ///CityRepository.CreateCity(City);
        }

        public void CreateFinance()
        {
            SetTax(0);
            SetMaintenance(0);
            SetCityFlouz(1500000);
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

        public void SetDatas(int satisfactionRate)
        {
            Happiness.SetSatisfactionRate(satisfactionRate);
        }


    }
}
