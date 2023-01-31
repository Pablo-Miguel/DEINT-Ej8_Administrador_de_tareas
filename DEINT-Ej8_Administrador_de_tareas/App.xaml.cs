using DEINT_Ej8_Administrador_de_tareas.MVVM.Views;

namespace DEINT_Ej8_Administrador_de_tareas;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new TareasView());
	}
}
