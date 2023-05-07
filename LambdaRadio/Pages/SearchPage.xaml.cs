namespace LambdaRadio.Pages;

public partial class SearchPage : ContentPage
{
	public SearchPage(SearchViewModel vm)
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
