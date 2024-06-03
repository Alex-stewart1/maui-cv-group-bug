namespace MauiGroupedCollectionMemoryLeak.Tests;

public class MainPage
{
    [Fact]
    public async Task MainPageShouldNotLeak()
    {
        //Arrange
        WeakReference mainPageReference = null;

        //Act
        {
            mainPageReference = new WeakReference(new MainPage());
        }

        //Assert
        await Task.Yield();
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Assert.False(mainPageReference.IsAlive);
    }
}