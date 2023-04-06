namespace TARge21SolarPlanets.Views;

public partial class PlanetsPage : ContentPage
{
	public PlanetsPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

		lstPopularPlanets.ItemsSource = PlanetsService.GetFeaturedPlanets();
    }

	async void Planets_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
	{

	}


    async void ApiPic_Clicked(System.Object sender, System.EventArgs e)
	{

	}


    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
	{

	}
}