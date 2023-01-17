using System.Text.Json;

namespace Aprendiendo_Net_MAUI.Mvvm.Views.ExternalResourcesDemo;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        this.LoadMauiAsset();
    }

    async Task LoadMauiAsset()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("data.json");
        using var reader = new StreamReader(stream);

        var contents = reader.ReadToEnd();
        var jsonObject = JsonSerializer.Deserialize<Person>(contents);
        var ver = true;
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
