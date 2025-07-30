using CollectionViewDemo.Models;
using CollectionViewDemo.ViewModels;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CollectionViewDemo.Views;

public partial class ProductsViewPage : ContentPage
{
    private readonly ProductsViewPageModel viewPageModel;

    public ProductsViewPage(ProductsViewPageModel viewPageModel)
	{
		InitializeComponent();
		BindingContext = viewPageModel;
        this.viewPageModel = viewPageModel;
    }

    private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
		Debug.WriteLine("--------------------------------------------------");
		Debug.WriteLine($"HorizontalDelta: {e.HorizontalDelta}");
		Debug.WriteLine($"VerticalDelta: {e.VerticalDelta}");
		Debug.WriteLine($"HorizontalOffset: {e.HorizontalOffset}");
		Debug.WriteLine($"VerticalOffset: {e.VerticalOffset}");
		Debug.WriteLine($"FirstVisibleItemIndex: {e.FirstVisibleItemIndex}");
		Debug.WriteLine($"CenterItemIndex: {e.CenterItemIndex}");
		Debug.WriteLine($"LastVisibleItemIndex: {e.LastVisibleItemIndex}");
        Debug.WriteLine("--------------------------------------------------");
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        ProductsGroup product = new(
            "New Group", [
                new(){
                    Id = 100,
                    Name = "Bitcoin",
                    Price = 999999m
                }]);
        ObservableCollection<ProductsGroup> products = viewPageModel.Products;
        products.Add(product);
        //Product? product = viewPageModel.Products.SelectMany(x => x).FirstOrDefault(p => p.Id == 10);
        //CollectionViewHandle.ScrollTo(product, animate: false,position: ScrollToPosition.Center);
    }
}