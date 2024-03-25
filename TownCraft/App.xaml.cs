using System.Configuration;
using System.Data;
using System.Windows;
using GameManagerNamespace;

namespace TownCraft
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>


    public partial class App : Application
    {
        private GameManager gameManager; // Déclarez une variable pour stocker l'instance de GameManager

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            gameManager = new GameManager(); // Instanciez GameManager

            // Affichez le menu au démarrage de l'application
            gameManager.ShowMenu();
        }
    }

}