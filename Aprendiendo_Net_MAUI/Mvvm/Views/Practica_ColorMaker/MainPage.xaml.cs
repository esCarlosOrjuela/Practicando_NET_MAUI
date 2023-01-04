using CommunityToolkit.Maui.Alerts;

namespace Aprendiendo_Net_MAUI.Mvvm.Views.Practica_ColorMaker;

public partial class MainPage : ContentPage
{
    bool isRandom;
    string hexValue;

    public MainPage()
    {
        InitializeComponent();
    }

    void Sliders_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        if (!isRandom)
        {
            var red = this.SliderRed.Value;
            var green = this.SliderGreen.Value;
            var blue = this.SliderBlue.Value;

            Color color = Color.FromRgb(red, green, blue);
            SetColor(color);
        }
    }

    private void SetColor(Color color)
    {
        btnRandom.BackgroundColor = color;
        Container.BackgroundColor = color;
        hexValue = color.ToHex();
        lblHex.Text = hexValue;
        lblHex.TextColor = color;


    }

    void btnRandom_Clicked(System.Object sender, System.EventArgs e)
    {
        isRandom = true;
        var random = new Random();
        var color = Color.FromRgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
        SetColor(color);

        SliderRed.Value = color.Red;
        SliderBlue.Value = color.Blue;
        SliderGreen.Value = color.Green;
        isRandom = false;
    }

    async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Clipboard.SetTextAsync(hexValue);
        var toast = Toast.Make("Color Copied", CommunityToolkit.Maui.Core.ToastDuration.Short, 12);
        await toast.Show();
    }
}
