using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TownCraft.Ui
{
    public partial class CreateGameUI : Page
    {
        private string playerName = "Player";
        private string cityName = "City";
        private GameManager _gameManager;

        public CreateGameUI()
        {
            InitializeComponent();
            _gameManager = ((App)Application.Current).GameManager;
        }

        private void GameButton_Click(object sender, RoutedEventArgs e)
        {
            Frame? menuFrame = FindParent<Frame>(this);
            if (menuFrame != null)
            {
                playerName = PlayerName.Text;
                cityName = CityName.Text;

                //var gameData = new Game;
                //{
                //    PlayerName = playerName;
                //    CityName = cityName;
                //};

                //_gameManager.StartGame(gameData);

                menuFrame.Navigate(new Uri("src/UI/GameUI.xaml", UriKind.Relative));
            }
        }

        private T? FindParent<T>(DependencyObject obj) where T : DependencyObject
        {
            DependencyObject? parent = VisualTreeHelper.GetParent(obj);
            while (parent != null && !(parent is T))
            {
                parent = VisualTreeHelper.GetParent(parent);
            }
            return parent as T;
        }
    }
}
