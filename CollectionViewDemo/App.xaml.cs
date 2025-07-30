using CollectionViewDemo.ViewModels;
using CollectionViewDemo.Views;

namespace CollectionViewDemo
{
    public partial class App : Application
    {
        private readonly DataPageViewModel dataPageViewModel;
        private readonly ProductsViewPageModel productsViewPageModel;

        public App(DataPageViewModel dataPageViewModel, ProductsViewPageModel productsViewPageModel)
        {
            InitializeComponent();
            this.dataPageViewModel = dataPageViewModel;
            this.productsViewPageModel = productsViewPageModel;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new LayoutsPageView(dataPageViewModel));
            return new Window(new ProductsViewPage(productsViewPageModel));
        }
    }
}