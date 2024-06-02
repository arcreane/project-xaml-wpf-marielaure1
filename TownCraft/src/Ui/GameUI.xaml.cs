using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TownCraft.Ui
{
    /// <summary>
    /// Logique d'interaction pour GameUI.xaml
    /// </summary>
    public partial class GameUI : Page
    {

        private GameManager _gameManager;

        public TownCraft.Core.Game Game { get; private set; }

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

        }





        private void ResidentialBuildingBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ResidentialBuildingModal.Visibility == Visibility.Visible)
            {
                ResidentialBuildingModal.Visibility = Visibility.Hidden;
            } else
            {
                ResidentialBuildingModal.Visibility = Visibility.Visible;
            }
        }
    }
}
