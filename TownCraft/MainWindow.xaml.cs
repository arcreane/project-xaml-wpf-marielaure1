using System.Configuration;
using System.Data;
using System.Windows;
///using GameManagerNamespace;

namespace TownCraft
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>


    public partial class App : Application
    {
        ///private GameManager gameManager; 


        protected override void OnStartup(StartupEventArgs e)
        {

            Console.WriteLine("Hello");
            string test = Console.ReadLine();
            ///base.OnStartup(e);

            ///gameManager = new GameManager(); 
            /// gameManager.ShowMenu();
        }
    }

}