namespace MauiGroupedCollectionMemoryLeak.UI;

public partial class HostPage : ContentPage
{
    public HostPage()
    {
        InitializeComponent();

        NavigationService.Init(Navigation);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await NavigationService.NavigateToMainPageAsync();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}