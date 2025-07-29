using CollectionViewDemo.ViewModels;
using CollectionViewDemo.Views;

namespace CollectionViewDemo
{
    public partial class App : Application
    {
        private readonly DataPageViewModel dataPageViewModel;

        public App(DataPageViewModel dataPageViewModel)
        {
            InitializeComponent();
            this.dataPageViewModel = dataPageViewModel;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new LayoutsPageView(dataPageViewModel));
            return new Window(new EmptyViewPage());
        }
    }
}