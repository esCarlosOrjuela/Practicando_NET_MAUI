namespace Aprendiendo_Net_MAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		this.Navigation.PushAsync(new Mvvm.Views.PageDemo());

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


