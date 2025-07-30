using CollectionViewDemo.ViewModels;

namespace CollectionViewDemo.Views;

public partial class ProductsViewPage : ContentPage
{
	public ProductsViewPage(ProductsViewPageModel viewPageModel)
	{
		InitializeComponent();
		BindingContext = viewPageModel;
	}
}