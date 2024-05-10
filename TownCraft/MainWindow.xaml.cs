using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace TownCraft
{
    public partial class MainWindow : Window
    {
        //private GameManager _gameManager;

        public MainWindow()
        {
            InitializeComponent();

            //_gameManager = ((App)Application.Current).GameManager;
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            if (MenuFrame != null && MenuFrame.CanGoBack)
            {
                MenuFrame.GoBack();
            }
        }

        private void MenuFrame_Navigated(object sender, NavigationEventArgs e)
        {
           
        }

    }
}
