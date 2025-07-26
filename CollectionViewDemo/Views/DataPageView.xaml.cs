using CollectionViewDemo.ViewModels;

namespace CollectionViewDemo.Views;

public partial class DataPageView : ContentPage
{
	public DataPageView(DataPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}