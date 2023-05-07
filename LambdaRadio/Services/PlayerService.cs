using SharedMauiLib;
namespace LambdaRadio.Services;

public class PlayerService
{
    private readonly INativeAudioService audioService;

    public bool IsPlaying { get; set; }


    public PlayerService(INativeAudioService audioService)
    {
        this.audioService = audioService;
        IsPlaying = false;
    }

    public void PlayAsync()
    {
        IsPlaying = !IsPlaying;
    }
}

