namespace MauiGroupedCollectionMemoryLeak;

public static class NavigationService
{
    private static INavigation? _navigation;

    public static void Init(INavigation navigation)
    {
        _navigation = navigation;
    }

    public static async Task NavigateToMainPageAsync()
    {
        if (_navigation == null)
        {
            throw new InvalidOperationException("Navigation not initialized");
        }

        await _navigation.PushAsync(new MainPage());
    }


    public static async Task NavigateBackAsync()
    {
        if (_navigation == null)
        {
            throw new InvalidOperationException("Navigation not initialized");
        }

        var page = await _navigation.PopAsync();

        (page as IDisposable)?.Dispose();
    }
}
