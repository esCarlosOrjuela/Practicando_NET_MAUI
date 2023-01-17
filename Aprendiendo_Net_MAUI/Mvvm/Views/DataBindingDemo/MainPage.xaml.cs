namespace Aprendiendo_Net_MAUI.Mvvm.Views.DataBindingDemo;

public partial class MainPage : ContentPage
{
    Models.DataBindingDemo.Person Person;

    public MainPage()
    {
        InitializeComponent();

        this.Person = new Models.DataBindingDemo.Person()
        {
            Name = "Martha",
            Phone = "350888",
            Address = "Tibana City"
        };

    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        var person2 = new Models.DataBindingDemo.Person
        {
            Name = "Mayerly",
            Phone = "321958",
            Address = "Tunja City"
        };

        Binding personBinding = new Binding();
        personBinding.Source = person2;
        personBinding.Path = "Address";
        txtAddress.SetBinding(Label.TextProperty, personBinding);


        txtName.BindingContext = person2;
        txtName.SetBinding(Label.TextProperty, "Name");
        txtPhone.BindingContext = person2;
        txtPhone.SetBinding(Label.TextProperty, "Phone");


        BindingContext = Person;



    }
}
