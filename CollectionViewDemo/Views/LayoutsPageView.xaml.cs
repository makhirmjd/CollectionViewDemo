using CollectionViewDemo.ViewModels;

namespace CollectionViewDemo.Views;

public partial class LayoutsPageView : ContentPage
{
	public LayoutsPageView(DataPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }

	private DataPageViewModel GetViewModel() => BindingContext as DataPageViewModel ?? new();
}