namespace LambdaRadio.Controls;

public partial class MiniPlayer : ContentView
{

    public MiniPlayer()
    {
        InitializeComponent();
    }

    private async void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        await Navigation.PushModalAsync(new FullPlayerPage());
    }

    void TapGestureRecognizer_Tapped_1(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        var imageSource = ImageSource.FromFile("pause.png");
        playpauseButton.Source = imageSource;
    }

    private async void SwipeGestureRecognizer_Swiped(System.Object sender, Microsoft.Maui.Controls.SwipedEventArgs e)
    {
        await Navigation.PushModalAsync(new FullPlayerPage());
    }
}
