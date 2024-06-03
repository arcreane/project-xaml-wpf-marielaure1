using System;
using TownCraft.Elements.Buildings;
using TownCraft.Elements.Buildings.Infrastructure;
using TownCraft.Elements.Buildings.ResidentialBuilding;
using TownCraft.Elements.Buildings.SecurityBuilding;
using TownCraft.Elements.Buildings.HealthBuilding;
using TownCraft.Elements.Buildings.CommercialBuilding;
using TownCraft.Satisfaction;
using TownCraft.Satisfaction.Resources;

namespace TownCraft.Core
{
    public class City
    {
        public Citizen Citizen { get; set; }
        public House House { get; set; }
        public SocialHousing SocialHousing { get; set; }
        public ApartmentBlock ApartmentBlock { get; set; }
        public EducationBuilding EducationBuilding { get; set; }
        public FireStation FireStation { get; set; }
        public PoliceStation PoliceStation { get; set; }

        private GameManager _gameManager;

        public City(GameManager gameManager)
        {
            _gameManager = gameManager; 
            Citizen = new TownCraft.Satisfaction.Citizen();
            InitializeGrid();
        }

        public string Name { get; set; }
        public int NumberOfCitizen { get; set; }
        public Cell[,] Grid { get; set; }

        private void InitializeGrid()
        {
            Grid = new Cell[50, 50];
            for (int x = 0; x < 50; x++)
            {
                for (int y = 0; y < 50; y++)
                {
                    Grid[x, y] = new Cell { X = x, Y = y, Available = true };
                }
            }
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetNumberOfCitizen(int numberOfCitizen)
        {
            NumberOfCitizen = numberOfCitizen;
        }

        public int GetNumberOfCitizen()
        {
            return NumberOfCitizen;
        }

        public Cell GetCell(int x, int y)
        {
            if (x >= 0 && x < 50 && y >= 0 && y < 50)
            {
                return Grid[x, y];
            }
            else
            {
                throw new ArgumentOutOfRangeException("Cell coordinates are out of bounds");
            }
        }

        public void ConstructBuilding(int x, int y, string type)
        {
            var cell = GetCell(x, y);
            if (cell.IsAvailable())
            {
                switch (type.ToLower())
                {
                    case "house":
                        House = new House();

                        if (!_gameManager.Game.Finance.RemoveFromCityFlouz(House.ConstructionCost))
                        {
                            
                        } else
                        {
                            cell.SetBuilding(House);
                            cell.Available = false;
                            NumberOfCitizen += House.NumberOfOccupants;
                            AddTaxRevenue(House.Tax);

                            AddResidenceResources(House.NumberOfOccupants);
                        }
                       
                        break;
                    default:
                        throw new ArgumentException("Unknown building type");
                }
            }
            else
            {
                
            }
        }

        public void AddTaxRevenue(decimal amount)
        {
            _gameManager.Game.Finance.AddToCityFlouz(amount);
        }

        public void AddResidenceResources(int numberOfOccupants)
        {
            _gameManager.Game.Residence.SetNumberOfOccupants(numberOfOccupants);
            _gameManager.Game.Residence.SetResidenceBuildings();
            _gameManager.Game.Residence.CalculateResidenceSatisfaction();

        }
    }
}
