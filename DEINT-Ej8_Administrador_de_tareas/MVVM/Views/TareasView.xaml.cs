using DEINT_Ej8_Administrador_de_tareas.MVVM.ViewModels;

namespace DEINT_Ej8_Administrador_de_tareas.MVVM.Views;

public partial class TareasView : ContentPage
{
	TareasViewModel tareasViewModel;
	public TareasView()
	{
		InitializeComponent();
		tareasViewModel = new TareasViewModel();

        BindingContext = tareasViewModel;
	}

    private void checkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		tareasViewModel.updateTasks();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(null);
    }
}