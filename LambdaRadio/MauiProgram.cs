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

		builder.Services.AddTransient<HomePage>();
		builder.Services.AddTransient<SearchPage>();
		builder.Services.AddTransient<FavoritesPage>();

		builder.Services.AddTransient<HomeViewModel>();
		builder.Services.AddTransient<SearchViewModel>();
		builder.Services.AddTransient<FavoritesViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

