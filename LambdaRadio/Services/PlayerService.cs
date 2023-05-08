using SharedMauiLib;

namespace LambdaRadio.Services;

public class PlayerService
{
    private readonly INativeAudioService audioService;

    public bool IsPlaying { get; set; }

    public event EventHandler IsPlayingChanged;

    public PlayerService(INativeAudioService audioService)
    {
        this.audioService = audioService;

        this.audioService.IsPlayingChanged += (object sender, bool e) =>
        {
            IsPlaying = e;
            IsPlayingChanged?.Invoke(this, EventArgs.Empty);
        };
    }

    public async Task PlayAsync()
    {
        await audioService.InitializeAsync("https://electrictooth.com/fm/stream/1433975767");

        InternalPlayPauseAsync();

        IsPlayingChanged?.Invoke(this, EventArgs.Empty);
    }

    private void InternalPlayPauseAsync()
    {
        IsPlaying = !IsPlaying;
    }
}

