using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MauiGroupedCollectionMemoryLeak.UI;

public partial class MainPage : ContentPage
{
    public List<AnimalGroup> AnimalCollection { get; } =
    [
        new AnimalGroup("Dog",
        [
            new Animal { Name = "Dog1", Type = "Dog" },
            new Animal { Name = "Dog2", Type = "Dog" },
        ]),
        new AnimalGroup("Cat",
        [
            new Animal { Name = "Cat1", Type = "Cat" },
            new Animal { Name = "Cat2", Type = "Cat" },
        ]),
    ];


    public MainPage()
    {
        InitializeComponent();

        BindingContext = this;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await NavigationService.NavigateBackAsync();
    }

    ~MainPage()
    {
        Debug.WriteLine(" ============ MainPage Destructor ===========");
    }
}

public class Animal
{
    public string Name { get; set; }
    public string Type { get; set; }
}

public class AnimalGroup : ObservableCollection<Animal>
{
    public string Key { get; }
    public AnimalGroup(string key, IEnumerable<Animal> animals) : base(animals)
    {
        Key = key;
    }
}
