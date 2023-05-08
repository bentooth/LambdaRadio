namespace LambdaRadio.ViewModels;

public partial class BaseViewModel : ObservableObject
{
	[ObservableProperty]
	string title;

    [ObservableProperty]
    private bool isLoading;

    [ObservableProperty]
    private bool isPlaying;
}