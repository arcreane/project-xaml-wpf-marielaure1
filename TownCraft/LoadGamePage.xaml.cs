namespace Towncraft;

public partial class LoadGamePage : ContentPage
{
	public LoadGamePage()
	{
		InitializeComponent();
	}

    private async void BackButton_Click(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}