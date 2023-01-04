namespace Aprendiendo_Net_MAUI.Mvvm.Views;

public partial class PageCommandsControlsDemo : ContentPage
{
    public PageCommandsControlsDemo()
    {
        InitializeComponent();
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        DisplayAlert("Test", "Click Demo", "OK");
    }

    void RadioButton_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
        DisplayAlert("RadioButton", $"Changed: {e.Value}", "OK");
    }

    void SearchBar_SearchButtonPressed(System.Object sender, System.EventArgs e)
    {
        DisplayAlert("Searching", $"Changed: {((SearchBar)sender).Text}", "OK");
    }

    void SwipeItem_Invoked(System.Object sender, System.EventArgs e)
    {
        DisplayAlert("Searching", "Element Tapped", "OK");
    }

    void Slider_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        rotatingLabel.Rotation = value;
        displayLabel.Text = String.Format("The Slider value is {0}", value);
    }

    void Stepper_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        _rotatingLabel.Rotation = value;
        _displayLabel.Text = string.Format("The Stepper value is {0}", value);
    }

    void Entry_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        DisplayAlert("Searching", $"Enter {e.NewTextValue}", "OK");
    }

    void Entry_Completed(System.Object sender, System.EventArgs e)
    {
        DisplayAlert("Searching", $"Terminado", "OK");
    }
}
