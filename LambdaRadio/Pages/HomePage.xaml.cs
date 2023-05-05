namespace LambdaRadio.Pages;

public partial class HomePage : ContentPage
{
	private readonly HomeViewModel _viewModel;

	public HomePage(HomeViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		_viewModel.Navigation = Navigation;
		BindingContext = _viewModel;
	}
}
