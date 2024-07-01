using Microsoft.Maui.Controls;
using System;

namespace Towncraft
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void NewGameButton_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateGamePage());
        }

        private async void LoadGameButton_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoadGamePage());
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }
    }
}
