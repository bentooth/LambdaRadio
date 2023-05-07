namespace LambdaRadio.Pages;

public partial class HomePage : ContentPage
{
    public HomePage(HomeViewModel vm)
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
