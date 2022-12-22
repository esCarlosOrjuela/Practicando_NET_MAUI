namespace Aprendiendo_Net_MAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        /// new NavigationPage(): Creamos un Control de Navegación, definiendo dentro del (), la pagina de inicio.
		var navigationPage = new NavigationPage(new MainPage());
		/// Definimos las caracteristicas que tendra el control de navegación creado
		navigationPage.BarBackground = Colors.Chocolate; 
		navigationPage.BarTextColor = Colors.White;
		/// Asignamos el control de navegación como pagina principal de la App
		MainPage = navigationPage;
        MainPage = new Mvvm.Views.PageCollectionsControlsDemo();

    }
}

