namespace LambdaRadio.ViewModels;

public partial class HomeViewModel : BaseViewModel
{
	PlayerService playerService;

	public HomeViewModel(PlayerService ps)
	{
		Title = "Home";
		this.playerService = ps;
	}

}