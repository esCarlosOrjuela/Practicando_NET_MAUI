namespace Aprendiendo_Net_MAUI.Mvvm.Views.Informacion_Propinas;

public partial class MainPage : ContentPage
{
    /// <summary>
    /// total de la cuenta
    /// </summary>
    decimal bill;

    /// <summary>
    /// % de propina
    /// </summary>
    int tip;

    /// <summary>
    /// Cantidad de personas
    /// </summary>
    int numPerson = 1;

    public MainPage()
    {
        InitializeComponent();


    }

    void txtBill_Completed(System.Object sender, System.EventArgs e)
    {
        bill = decimal.Parse(txtBill.Text);

        CalculateTotal();

    }

    void sldTip_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        tip = (int)sldTip.Value;
        lblTip.Text = $"Tip: {tip}%";
        CalculateTotal();
    }
    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        if (sender is Button)
        {
            var btn = (Button)sender;
            var percentage = int.Parse(btn.Text.Replace("%", string.Empty));
            sldTip.Value = percentage;
        }
    }

    void btnMinus_Clicked(System.Object sender, System.EventArgs e)
    {
        if (numPerson > 1)
            numPerson--;

        lblNumPerson.Text = numPerson.ToString();
        CalculateTotal();
    }

    void btnPlus_Clicked(System.Object sender, System.EventArgs e)
    {
        numPerson++;
        lblNumPerson.Text = numPerson.ToString();
        CalculateTotal();
    }

    private void CalculateTotal()
    {
        var totalTip = (bill * tip) / 100;
        var tipByPerson = totalTip / numPerson;
        lblTipByPerson.Text = $"{tipByPerson:C}";

        var subTotal = (bill / numPerson);
        lblSubTotal.Text = $"{subTotal:C}";

        var totalByPerson = (bill + totalTip) / numPerson;
        lblTotal.Text = $"{totalByPerson:C}";
    }
}
