using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using TownCraft.Core;
using TownCraft.Elements.Buildings;
using TownCraft.Elements.Buildings.ResidentialBuilding;

namespace TownCraft.Ui
{
    public partial class GameUI : Page
    {
        private GameManager _gameManager;
        public TownCraft.Core.Game Game { get; private set; }
        private Button selectedCell;
        private bool cellASelected = false;

        public GameUI()
        {
            InitializeComponent();
            _gameManager = ((App)Application.Current).GameManager;
            Game = _gameManager.StartGame();
            PlayerBtnText.Text = Game.Player.Name;
            CityBtnText.Text = Game.City.Name;
            NumberOfCitizenText.Text = Game.City.NumberOfCitizen.ToString();
            FinanceBtnText.Text = Game.Finance.CityFlouz.ToString();
            HapinessBtnText.Text = Game.Happiness.SatisfactionRate.ToString();
            InitializeCityGrid();
        }

        private void InitializeCityGrid()
        {
            for (int x = 0; x < 50; x++)
            {
                for (int y = 0; y < 50; y++)
                {
                    Button cellButton = new Button
                    {
                        Width = 100,
                        Height = 100,
                        Margin = new Thickness(1),
                        Tag = new { X = x, Y = y }
                    };

                    cellButton.Click += CellButton_Click;
                    CityGrid.Items.Add(cellButton);
                }
            }
        }

        private void CellButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button clickedCell)
            {
                var cellCoordinates = (dynamic)clickedCell.Tag;
                int cellX = cellCoordinates.X;
                int cellY = cellCoordinates.Y;
                var cell = Game.City.GetCell(cellX, cellY);

                if (selectedCell != null)
                {
                    if (cellASelected)
                    {
                        var previousCoordinates = (dynamic)selectedCell.Tag;
                        var previousCell = Game.City.GetCell(previousCoordinates.X, previousCoordinates.Y);

                        if (previousCell.IsAvailable())
                        {
                            selectedCell.Background = Brushes.White;
                        }
                        else
                        {
                            selectedCell.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/src/Ui/Exterior.png")));
                        }
                        selectedCell = null;
                        cellASelected = false;
                    }
                }

                if (cell.IsAvailable())
                {
                    selectedCell = clickedCell;
                    selectedCell.Background = Brushes.LightBlue;
                    cellASelected = true;
                }
                else
                {
                    clickedCell.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/src/Ui/Exterior.png")));
                }
            }
        }

        private void HouseBtn_Click(object sender, RoutedEventArgs e)
        {
            ConstructBuilding("house");
        }

        private void EducationBuildingBtn_Click(object sender, RoutedEventArgs e)
        {
            ConstructBuilding("education");
        }

        private void SecurityBuildingBtn_Click(object sender, RoutedEventArgs e)
        {
            ConstructBuilding("security");
        }

        private void HealthBuildingBtn_Click(object sender, RoutedEventArgs e)
        {
            ConstructBuilding("health");
        }

        private void ElectricityBuildingBtn_Click(object sender, RoutedEventArgs e)
        {
            ConstructBuilding("electricity");
        }

        private void HobbiesBuildingBtn_Click(object sender, RoutedEventArgs e)
        {
            ConstructBuilding("hobbies");
        }

        private void InfrastructureBuildingBtn_Click(object sender, RoutedEventArgs e)
        {
            ConstructBuilding("infrastructure");
        }

        private void WaterBuildingBtn_Click(object sender, RoutedEventArgs e)
        {
            ConstructBuilding("water");
        }

        private void ConstructBuilding(string type)
        {
            if (selectedCell != null)
            {
                var cellCoordinates = (dynamic)selectedCell.Tag;
                int cellX = cellCoordinates.X;
                int cellY = cellCoordinates.Y;

                var cell = Game.City.GetCell(cellX, cellY);

                if (cell.IsAvailable())
                {
                    Game.City.ConstructBuilding(cellX, cellY, type);

                    switch (type.ToLower())
                    {
                        case "house":
                            selectedCell.Background = new ImageBrush(new BitmapImage(new Uri(Game.City.House.GetImageLevel())));
                            break;
                        case "social-housing":
                            selectedCell.Background = new ImageBrush(new BitmapImage(new Uri(Game.City.House.GetImageLevel())));
                            break;
                        case "apartment-block":
                            selectedCell.Background = new ImageBrush(new BitmapImage(new Uri(Game.City.House.GetImageLevel())));
                            break;
                        case "education":
                            selectedCell.Background = new ImageBrush(new BitmapImage(new Uri(Game.City.EducationBuilding.GetImageLevel())));
                            break;
                        case "firestation":
                            selectedCell.Background = new ImageBrush(new BitmapImage(new Uri(Game.City.FireStation.GetImageLevel())));
                            break;
                        case "policestation":
                            selectedCell.Background = new ImageBrush(new BitmapImage(new Uri(Game.City.PoliceStation.GetImageLevel())));
                            break;
                        case "hospital":
                            break;
                        case "clinique":
                            break;
                        case "electricity":
                            break;
                        case "hobbies":
                            break;
                        case "infrastructure":
                            break;
                        case "water":
                            break;
                        default:
                            throw new ArgumentException("Unknown building type");
                    }

                    MessageBox.Show($"House constructed at ({cellX}, {cellY})");


                    NumberOfCitizenText.Text = Game.City.NumberOfCitizen.ToString();
                    FinanceBtnText.Text = Game.Finance.CityFlouz.ToString();
                    ResidenceResourcesText.Text = Game.Residence.SatisfactionRate.ToString();
                }
                else
                {
                    MessageBox.Show("The selected cell is not available for construction.");
                }

                selectedCell = null;
                cellASelected = false;
            }
        }

        private void ResidentialBuildingBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ResidentialBuildingModal.Visibility == Visibility.Visible)
            {
                ResidentialBuildingModal.Visibility = Visibility.Hidden;
            }
            else
            {
                ResidentialBuildingModal.Visibility = Visibility.Visible;
            }
        }
    }
}
