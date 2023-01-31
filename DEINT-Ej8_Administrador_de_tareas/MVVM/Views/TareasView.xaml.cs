using DEINT_Ej8_Administrador_de_tareas.MVVM.ViewModels;

namespace DEINT_Ej8_Administrador_de_tareas.MVVM.Views;

public partial class TareasView : ContentPage
{
	public TareasView()
	{
		InitializeComponent();
		BindingContext = new TareasViewModel();
	}
}