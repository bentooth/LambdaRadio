namespace LambdaRadio.Pages;

public partial class FavoritesPage : ContentPage
{

	public FavoritesPage(FavoritesViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        player.OnAppearing();
    }


    protected override void OnDisappearing()
    {
        player.OnDisappearing();
        base.OnDisappearing();
    }
}
