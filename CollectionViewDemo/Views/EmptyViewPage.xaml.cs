namespace CollectionViewDemo.Views;

public partial class EmptyViewPage : ContentPage
{
	public EmptyViewPage()
	{
		InitializeComponent();
	}

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
		bool isToggled = e.Value;
		CollectionView.EmptyView = isToggled ? Resources["NoResultsView"] : Resources["ConnectivityIssueView"];
    }
}