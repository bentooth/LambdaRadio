namespace LambdaRadio.Pages;

public partial class FullPlayerPage : ContentPage
{
	public FullPlayerPage()
	{
		InitializeComponent();
	}

    private async void SwipeGestureRecognizer_Swiped(System.Object sender, Microsoft.Maui.Controls.SwipedEventArgs e)
    {
		await Navigation.PopModalAsync();
    }
}
