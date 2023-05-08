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

    private async void TapGestureRecognizer_Tapped_1(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
       await playerService.PlayAsync();
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
        this.playerService.IsPlayingChanged -= PlayerService_IsPlayingChanged;
    }

    void InitPlayer()
    {
        if (playerService == null)
            return;

        this.playerService.IsPlayingChanged += PlayerService_IsPlayingChanged;

        UpdatePlayPause();
    }

    private void UpdatePlayPause()
    {
        this.playButton.Source = this.playerService.IsPlaying ? "pause.png" : "play.png";
    }

    private void PlayerService_IsPlayingChanged(object sender, EventArgs e)
    {
      
        UpdatePlayPause();
    }
}
