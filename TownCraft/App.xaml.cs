using Microsoft.Maui.Controls;
using Towncraft;
///using Towncraft.Gameplay;

namespace Towncraft
{
    public partial class App : Application
    {
       // public GameManager GameManager { get; private set; }

        public App()
        {
            InitializeComponent();
            // GameManager = new GameManager();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
