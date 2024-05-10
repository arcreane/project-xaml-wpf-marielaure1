using System.Configuration;
using System.Data;
using System.Windows;
using TownCraft.Gameplay;

namespace TownCraft
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public TownCraft.GameManager GameManager { get; private set; }

        public App()
        {
            GameManager = new GameManager();
        }
    }

}
