namespace LambdaRadio.Pages;

public partial class FavoritesPage : ContentPage
{
	private readonly FavoritesViewModel _viewModel;

	public FavoritesPage(FavoritesViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		_viewModel.Navigation = Navigation;
		BindingContext = _viewModel;
	}
}
