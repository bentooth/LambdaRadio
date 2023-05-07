using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace LambdaRadio;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Spotify-Bold.woff2", "SpotifyBold");
                fonts.AddFont("Spotify-Light", "SpotifyLight");
            });

        /*
			Before we can use this ViewModel in a View,
			we need to register it with the service collection in MauiProgram
			so that we can inject it into the View’s constructor. 
		 */

        builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<SearchPage>();
        builder.Services.AddSingleton<FavoritesPage>();

        builder.Services.AddTransient<HomeViewModel>();
        builder.Services.AddTransient<SearchViewModel>();
        builder.Services.AddTransient<FavoritesViewModel>();

        builder.Services.TryAddSingleton<PlayerService>();


#if WINDOWS
        builder.Services.TryAddSingleton<SharedMauiLib.INativeAudioService, SharedMauiLib.Platforms.Windows.NativeAudioService>();
#elif ANDROID
        builder.Services.TryAddSingleton<SharedMauiLib.INativeAudioService, SharedMauiLib.Platforms.Android.NativeAudioService>();
#elif MACCATALYST
        builder.Services.TryAddSingleton<SharedMauiLib.INativeAudioService, SharedMauiLib.Platforms.MacCatalyst.NativeAudioService>();
#elif IOS
        builder.Services.TryAddSingleton<SharedMauiLib.INativeAudioService, SharedMauiLib.Platforms.iOS.NativeAudioService>();
#endif


#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}

