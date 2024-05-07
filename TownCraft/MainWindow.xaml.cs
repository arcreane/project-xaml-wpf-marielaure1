using System.Windows;

namespace TownCraft
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_CreateGame_Click(object sender, RoutedEventArgs e)
        {
            // Afficher le formulaire de création de partie
            createFormGrid.Visibility = Visibility.Visible;
            MenuChoice.Visibility = Visibility.Hidden;
        }

        private void MenuItem_LoadGame_Click(object sender, RoutedEventArgs e)
        {
            // Implémentez ici le chargement d'une partie
            createFormGrid.Visibility = Visibility.Hidden;
            MenuChoice.Visibility = Visibility.Visible;
        }
    }
}
