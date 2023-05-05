namespace LambdaRadio.Pages;

public partial class SearchPage : ContentPage
{
	private readonly SearchViewModel _viewModel;

	public SearchPage(SearchViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		_viewModel.Navigation = Navigation;
		BindingContext = _viewModel;
	}
}
