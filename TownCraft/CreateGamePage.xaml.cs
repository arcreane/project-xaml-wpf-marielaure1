using Microsoft.Maui.Controls;
using System;

namespace Towncraft
{
    public partial class CreateGamePage : ContentPage
    {
        public CreateGamePage()
        {
            InitializeComponent();
        }

        private async void PlayButton_Click(object sender, EventArgs e)
        {
            string playerName = PlayerNameEntry.Text;
            string cityName = CityNameEntry.Text;

            if (string.IsNullOrEmpty(playerName) || string.IsNullOrEmpty(cityName))
            {
                await DisplayAlert("Erreur", "Veuillez remplir tous les champs", "OK");
                return;
            }
            await Navigation.PushAsync(new GameUI());
        }

        private async void BackButton_Click(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
