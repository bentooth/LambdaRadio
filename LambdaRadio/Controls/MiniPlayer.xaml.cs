namespace LambdaRadio.Controls;

public partial class MiniPlayer : ContentView
{
    private PlayerService playerService;

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
       playerService.PlayAsync();

       this.playButton.Source = this.playerService.IsPlaying ? "pause.png" : "play.png";
    }

    private async void SwipeGestureRecognizer_Swiped(System.Object sender, Microsoft.Maui.Controls.SwipedEventArgs e)
    {
        await Navigation.PushModalAsync(new FullPlayerPage());
    }


    protected override void OnHandlerChanged()
    {
        base.OnHandlerChanged();

        if (playerService == null)
        {
            this.playerService = this.Handler.MauiContext.Services.GetService<PlayerService>();
            InitPlayer();
        }
    }

    internal void OnAppearing()
    {
        InitPlayer();
    }

    internal void OnDisappearing()
    {
        
    }

    void InitPlayer()
    {
        if (playerService == null)
            return;
    }
}
