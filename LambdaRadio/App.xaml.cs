namespace LambdaRadio;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new AppShell();

        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(SearchPage), typeof(SearchPage));
        Routing.RegisterRoute(nameof(FavoritesPage), typeof(FavoritesPage));
    }
}

