using DEINT_Ej8_Administrador_de_tareas.MVVM.ViewModels;

namespace DEINT_Ej8_Administrador_de_tareas.MVVM.Views;

public partial class AnyadirView : ContentPage
{
    private AnyadirViewModel anyadirViewModel;
    public AnyadirView(TareasViewModel tareasViewModel)
	{
		InitializeComponent();
        anyadirViewModel = new AnyadirViewModel(tareasViewModel);
        BindingContext = anyadirViewModel;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (anyadirViewModel.SelectedCategory != -1) {
            anyadirViewModel.SelectedCategory = -1;
            Navigation.PopToRootAsync();
        }
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton rb = sender as RadioButton;
        anyadirViewModel.SelectedCategory = (int) rb.Value;
    }
}